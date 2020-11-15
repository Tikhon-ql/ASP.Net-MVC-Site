using System;

namespace Comments.DAL.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
