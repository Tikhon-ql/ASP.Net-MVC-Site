using Comments.DAL.Models;
using Comments.Interfaces.ChildRepos;
using Comments.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Comments.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        CommentContext db;
        public CommentRepository(CommentContext db)
        {
            this.db = db;
        }
        public void Create(Comment data)
        {
            if (data == null)
                throw new NullReferenceException();
            db.Comments.Add(data);
            db.SaveChanges();
        }

        public void Delete(Comment data)
        {
            if (data == null)
                throw new NullReferenceException();
            db.Comments.Remove(data);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Comment Read(int id)
        {
            if (id < 0)
                throw new ArgumentException("Id cannot be negative");
            Comment data = db.Comments.FirstOrDefault(c=>c.Id == id);
            if (data == null)
                throw new Exception($"Комментария с id - {id} не существует");
            return data;
        }

        public IEnumerable<Comment> ReadAll()
        {
            return db.Comments.ToList();
        }

        public void Update(Comment data)
        {
            if (data == null)
                throw new NullReferenceException();
            Comment old = db.Comments.FirstOrDefault(c => c.Id == data.Id);
            if (data == null)
                throw new Exception($"Комментария с id - {data.Id} не существует");
            old.Nickname = data.Nickname;
            old.Text = data.Text;
            old.Date = data.Date;
            db.SaveChanges();
        }
    }
}
