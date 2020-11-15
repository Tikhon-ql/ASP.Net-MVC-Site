using Comments.DAL.Models;
using System.Data.Entity;

namespace Comments.Models.Contexts
{
    public class CommentContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public CommentContext(string connectionString):base(connectionString)
        {

        }
    }
}
