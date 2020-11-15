using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfWork_1.Models.Animals
{
    public class Video
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}