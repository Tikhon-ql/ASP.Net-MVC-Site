using Comment.BLL.Models.DTO;
using System;

namespace Comment.BLL.Models
{
    public class CommentDTO:IDTO
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
