using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SelfWork_1.Models.Contexts
{
    public class CommentsContext:DbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}