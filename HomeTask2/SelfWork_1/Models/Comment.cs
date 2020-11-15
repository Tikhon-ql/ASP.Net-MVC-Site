using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfWork_1.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}