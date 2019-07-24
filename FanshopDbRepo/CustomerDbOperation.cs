using System;
using System.Configuration;
using FanshopDbDAL;
using FanshopBaseData.BaseModels;

namespace FanshopDbRepo
{
    public class CustomerDbOperation<T> where T: BaseCustomer
    {
        private BaseRepo<BaseCustomer> repo;
        public CustomerDbOperation()
        {
            switch (ConfigurationManager.AppSettings.Get("AccessType"))
            {
                case "ADO":
                    repo = new CustomerRepoAccessADO();
                    break;
                case "EF":
                    repo = new CustomerRepoAccessEF();
                    break;
                case "EFCore":
                    repo = new CustomerRepoAccessEFCore();
                    break;
                default:
                    Console.WriteLine("Иди домой");
                    break;
            }
        }
        public void Add(BaseCustomer customer)
        {
            repo.Add(customer);
        }
    }
}