using System;
using FanshopDbDataAccessLibrary.BaseModels.BaseEntity;
using FanshopDbDataAccessLibrary.Interface;
using Microsoft.EntityFrameworkCore;

namespace FanshopDbEFCore
{
    public class FanshopEfCoreOperations<T> : IDisposable, IDbOperations<T> where T : BaseEntity
    {
        private readonly DbSet<T> Table;
        private readonly FanshopDemoDbContext context;
        public FanshopEfCoreOperations()
        {
            context =  new FanshopDemoDbContext();
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