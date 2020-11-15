using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SelfWork_1.Models.Animals.Context
{
    public class AnimalsContext:DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}