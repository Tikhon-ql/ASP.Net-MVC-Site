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
    public class TeamPlayerRepository : ITeamPlayerRepository
    {
        TeamPlayerContext db;
        public TeamPlayerRepository(TeamPlayerContext db)
        {
            this.db = db;
        }
        public void Create(TeamPlayer data)
        {
            if (data == null)
                throw new NullReferenceException();
            db.TeamPlayers.Add(data);
            db.SaveChanges();
        }

        public void Delete(TeamPlayer data)
        {
            if (data == null)
                throw new NullReferenceException();
            db.TeamPlayers.Remove(data);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public TeamPlayer Read(int id)
        {
            if (id < 0)
                throw new ArgumentException("Id cannot be negative");
            TeamPlayer data = db.TeamPlayers.FirstOrDefault(c => c.Id == id);
            if (data == null)
                throw new Exception($"Игрока с id - {id} не существует");
            return data;
        }

        public IEnumerable<TeamPlayer> ReadAll()
        {
            return db.TeamPlayers.ToList();
        }

        public void Update(TeamPlayer data)
        {
            if (data == null)
                throw new NullReferenceException();
            TeamPlayer old = db.TeamPlayers.FirstOrDefault(c => c.Id == data.Id);
            if (data == null)
                throw new Exception($"Комментария с id - {data.Id} не существует");
            old.Id = data.Id;
            old.Name = data.Name;
            old.Surname = data.Surname;
            old.Bithday = data.Bithday;
            old.CommandName = data.CommandName;
            old.Height = data.Height;
            old.Weight = data.Weight;
            old.ImagePath = data.ImagePath;
            old.Position = data.Position;
            db.SaveChanges();
        }
    }
}
