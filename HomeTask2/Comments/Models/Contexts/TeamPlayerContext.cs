using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Models.Contexts
{
    public class TeamPlayerContext:DbContext
    {
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
        public TeamPlayerContext(string connectionString):base(connectionString)
        {
        }
    }
}
