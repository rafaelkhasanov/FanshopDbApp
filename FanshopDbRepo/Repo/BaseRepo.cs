using FanshopDbDataAccessLibrary.BaseModels.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanshopDbDataAccessLibrary.Interface;

namespace FanshopDbDAL
{
    public abstract class BaseRepo<T> : IDbOperations<T>, IDisposable where T : BaseEntity
    {
        public virtual int Add(T entity)
        {
            return 1;
        }

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual T GetOne(int? id)
        {
            throw new NotImplementedException();
        }

        public virtual int Save()
        {
            throw new NotImplementedException();
        }
    }
}
