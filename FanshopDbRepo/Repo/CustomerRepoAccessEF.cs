using System;
using System.Data.Entity;
using FanshopBaseData.BaseModels;
using FanshopDbEF;

namespace FanshopDbDAL
{
    public class CustomerRepoAccessEF : BaseRepo<BaseCustomer>
    {
        private readonly DbSet<Customer> Table;
        private readonly FanshopEFContext context;
        public CustomerRepoAccessEF()
        {
            context = new FanshopEFContext();
            Table = context.Set<Customer>();
        }

        public override int Add(BaseCustomer baseCustomer)
        {
            Table.Add(baseCustomer as Customer ?? throw new InvalidOperationException());
            return Save();
        }
        public override BaseCustomer GetOne(int? id) => Table.Find(id);
        public override int Save() => context.SaveChanges();
        public void Dispose()
        {
            context?.Dispose();
        }
    }
}