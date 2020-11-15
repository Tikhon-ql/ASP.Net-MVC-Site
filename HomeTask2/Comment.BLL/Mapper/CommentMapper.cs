using Comment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comment.BLL.Mapper
{
    public class CommentMapper
    {
        public static Comments.DAL.Models.Comment FromDTO(CommentDTO commentDTO)
        {
            Comments.DAL.Models.Comment com = new Comments.DAL.Models.Comment
            {
                Id = commentDTO.Id,
                Nickname = commentDTO.Nickname,
                Text = commentDTO.Text,
                Date = commentDTO.Date
            };
            return com;
        }
        public static CommentDTO ToDTO(Comments.DAL.Models.Comment comment)
        {
            CommentDTO com = new CommentDTO
            {
                Id = comment.Id,
                Nickname = comment.Nickname,
                Text = comment.Text,
                Date = comment.Date
            };
            return com;
        }
        public static List<CommentDTO> ToDTO(List<Comments.DAL.Models.Comment> comments)
        {
            return comments.ConvertAll(c => new CommentDTO
            {
                Id = c.Id,
                Nickname = c.Nickname,
                Text = c.Text,
                Date = c.Date
            });
        }
        public static List<Comments.DAL.Models.Comment> FromDTO(List<CommentDTO> comments)
        {
            return comments.ConvertAll(c => new Comments.DAL.Models.Comment
            {
                Id = c.Id,
                Nickname = c.Nickname,
                Text = c.Text,
                Date = c.Date
            });
        }
    }
}
