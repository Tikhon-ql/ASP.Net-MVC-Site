using Comment.BLL.Interfaces.ChildServices;
using Comment.BLL.Mapper;
using Comment.BLL.Models;
using Comments.Interfaces.ChildRepos;
using Comments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comment.BLL.Services
{
    public class PlayerService : IPlayerService
    {
        IPlayerRepository repository;
        public PlayerService(IPlayerRepository repository)
        {
            this.repository = repository;
        }
        public void Create(PlayerDTO data)
        {
            if (data == null)
                throw new NullReferenceException();
            Player player = PlayerMapper.FromDTO(data);
            repository.Create(player);
        }

        public void Delete(PlayerDTO data)
        {
            if (data == null)
                throw new NullReferenceException();
            Player player = PlayerMapper.FromDTO(data);
            repository.Delete(player);
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public PlayerDTO Read(int id)
        {

            if (id < 0)
                throw new ArgumentException("Id cannot be negative");
            Player player = repository.ReadAll().FirstOrDefault(c => c.Id == id);
            if (player == null)
                throw new Exception($"Игрока с id - {id} не существует");
            return PlayerMapper.ToDTO(player);
        }

        public IEnumerable<PlayerDTO> ReadAll()
        {
            return PlayerMapper.ToDTO(repository.ReadAll().ToList());
        }

        public void Update(PlayerDTO data)
        {
            if (data == null)
                throw new NullReferenceException();
            Player player = PlayerMapper.FromDTO(data);
            repository.Update(player);
        }
    }
}
