using System;
using FanshopDbDataAccessLibrary.BaseModels.BaseEntity;
using FanshopDbDataAccessLibrary.Interface;
using System.Data.Entity;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEF
{
    public class FanshopEfOperations<T> : IDisposable, IDbOperations<T> where T : BaseCustomer
    {
        private readonly DbSet<T> Table;
        private readonly FanshopDbEfContext context;

        public FanshopEfOperations()
        {
            context = new FanshopDbEfContext();
            Table = context.Set<T>();
        }

        public int Add(T entity)
        {
            Table.Add(entity);
            return Save();
        }
        public T GetOne(int? id) => Table.Find(id);
        public int Save() => context.SaveChanges();
        public void Dispose()
        {
            context?.Dispose();
        }
    }

}