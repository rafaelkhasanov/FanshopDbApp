using System;
using System.Configuration;
using FanshopBaseData.BaseModels;
using FanshopDbADO;
using FanshopDbEF;
using FanshopDbEFCore;
using FanshopDbRepo;

namespace FanshopDbApp
{
    class Program
    {
        static BaseCustomer customer;
        static void Main()
        {
            var customerOperation = new CustomerDbOperation<BaseCustomer>();
            customerOperation.Add(customer);
        }
        public Program()
        {
            switch (ConfigurationManager.AppSettings.Get("type"))
            {
                case "ADO": customer = new FanshopDbADO.Customer();
                    break;
                case "EF": customer = new FanshopDbEF.Customer();
                    break;
                case "EFCore": customer = new FanshopDbEFCore.Customer();
                    break;
                default:
                    Console.WriteLine("Иди домой");
                    break;
            }

        }
    }
}
