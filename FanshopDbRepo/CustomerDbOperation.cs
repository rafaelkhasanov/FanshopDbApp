using FanshopDbDAL;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbRepo
{
    public class CustomerDbOperation<T> where T: BaseCustomer
    {
        private BaseRepo<BaseCustomer> repo;
        public CustomerDbOperation() => repo = new CustomerRepoAccessEF();
        public void Add(BaseCustomer customer)
        {
            repo.Add(customer);
        }
    }
}