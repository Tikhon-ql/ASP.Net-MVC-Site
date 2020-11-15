using Comments.Interfaces.ChildRepos;
using Comments.Models;
using Comments.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        PlayersContext db;
        public PlayerRepository(PlayersContext db)
        {
            this.db = db;
        }
        public void Create(Player data)
        {
            if (data == null)
                throw new NullReferenceException();
            db.Players.Add(data);
            db.SaveChanges();
        }

        public void Delete(Player data)
        {
            if (data == null)
                throw new NullReferenceException();
            db.Players.Remove(data);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Player Read(int id)
        {
            if (id < 0)
                throw new ArgumentException("Id cannot be negative");
            Player data = db.Players.FirstOrDefault(c => c.Id == id);
            if (data == null)
                throw new Exception($"Игрок с id - {id} не существует");
            return data;
        }

        public IEnumerable<Player> ReadAll()
        {
            return db.Players.ToList();
        }

        public void Update(Player data)
        {
            if (data == null)
                throw new NullReferenceException();
            Player old = db.Players.FirstOrDefault(c => c.Id == data.Id);
            if (data == null)
                throw new Exception($"Игрок с id - {data.Id} не существует");
            old.Id = data.Id;
            old.Name = data.Name;
            old.Surname = data.Surname;
            old.Position = data.Position;
            old.ImagePath = data.ImagePath;
            old.Height = data.Height;
            old.Weight = data.Weight;
            old.CommandName = data.CommandName;
            old.Bithday = data.Bithday;
            db.SaveChanges();
        }
    }
}
