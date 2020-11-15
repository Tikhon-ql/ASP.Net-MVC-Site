using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Models.Contexts
{
    public class PlayersContext:DbContext
    {
        public DbSet<Player> Players { get; set; }
        public PlayersContext(string connectionString) : base(connectionString)
        {

        }
    }
}
