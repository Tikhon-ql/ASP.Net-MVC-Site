using System;
using System.Collections.Generic;

namespace Comments.Interfaces
{
    public interface IRepository<T>:IDisposable where T:class
    {
        void Create(T data);
        void Delete(T data);
        T Read(int id);
        void Update(T data);
        IEnumerable<T> ReadAll();
    }
}
