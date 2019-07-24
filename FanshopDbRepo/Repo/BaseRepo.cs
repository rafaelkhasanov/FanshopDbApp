using FanshopBaseData.BaseModels.BaseEntity;
using System;
using FanshopBaseData.Interface;

namespace FanshopDbDAL
{
    public abstract class BaseRepo<T> : IDbOperations<T>, IDisposable where T : BaseEntity
    {
        public abstract int Add(T entity);
        public virtual int Save() => throw new NotImplementedException();
        public virtual T GetOne(int? id) => throw new NotImplementedException();
        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
