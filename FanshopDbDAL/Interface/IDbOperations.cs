using System;

namespace FanshopDbDataAccessLibrary.Interface
{
    public interface IDbOperations<T> : IDisposable
    {
        int Add(T entity);
        int Save();
        T GetOne(int? id);
    }
}