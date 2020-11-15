using Comment.BLL.Models.DTO;
using System;
using System.Collections.Generic;

namespace Comment.BLL.Interfaces.MainService
{
    public interface IService<T> : IDisposable where T:IDTO
    {
        void Create(T data);
        void Delete(T data);
        T Read(int id);
        void Update(T data);
        IEnumerable<T> ReadAll();
    }
}
