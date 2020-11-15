using Comment.BLL.Interfaces.ChildServices;
using Comment.BLL.Mapper;
using Comment.BLL.Models;
using Comment.BLL.Validators;
using Comments.Interfaces.ChildRepos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Comment.BLL.Services
{
    public class CommentService : ICommentService
    {
        ICommentRepository repository;
        public CommentService(ICommentRepository repository)
        {
            this.repository = repository;
        }
        public void Create(CommentDTO data)
        {
            if (data == null)
                throw new NullReferenceException();
            if (!Validator.IsNicknameCorrect(data.Nickname))
                throw new ArgumentException("Неправильный формат имени");
            Comments.DAL.Models.Comment comment = CommentMapper.FromDTO(data);
            repository.Create(comment);
        }

        public void Delete(CommentDTO data)
        {
            if (data == null)
                throw new NullReferenceException();
            Comments.DAL.Models.Comment comment = CommentMapper.FromDTO(data);
            repository.Delete(comment);
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public CommentDTO Read(int id)
        {
            if (id < 0)
                throw new ArgumentException("Id cannot be negative");
            Comments.DAL.Models.Comment comment = repository.ReadAll().FirstOrDefault(c => c.Id == id);
            if (comment == null)
                throw new Exception($"Комментария с id - {id} не существует");
            return CommentMapper.ToDTO(comment);
        }

        public IEnumerable<CommentDTO> ReadAll()
        {
            return CommentMapper.ToDTO(repository.ReadAll().ToList());
        }

        public void Update(CommentDTO data)
        {
            if (data == null)
                throw new NullReferenceException();
            if (!Validator.IsNicknameCorrect(data.Nickname))
                throw new ArgumentException("Неправильный формат времени");
            Comments.DAL.Models.Comment comment = CommentMapper.FromDTO(data);
            repository.Update(comment);
        }
    }
}
