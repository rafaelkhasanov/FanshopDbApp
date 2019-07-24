using System;
using FanshopBaseData.BaseModels;
using FanshopDbEFCore;
using Microsoft.EntityFrameworkCore;

namespace FanshopDbDAL
{
    public class CustomerRepoAccessEFCore : BaseRepo<BaseCustomer>
    {
        private readonly DbSet<Customer> Table;
        private readonly FanshopEFCoreContext context;
        public CustomerRepoAccessEFCore()
        {
            context = new FanshopEFCoreContext();
            Table = context.Set<Customer>();
        }
        public override int Add(BaseCustomer entity)
        {
            Table.Add(entity as Customer ?? throw new InvalidOperationException());
            return Save();
        }
        public override BaseCustomer GetOne(int? id) => Table.Find(id);
        public override int Save() => context.SaveChanges();
        public override void Dispose()
        {
            context?.Dispose();
        }
    }
}