using System;
using System.Configuration;
using FanshopBaseData.BaseModels;
using FanshopDbRepo;

namespace FanshopDbApp
{
    class Program
    {
        static BaseCustomer customer;
        static void Main()
        {
            customer = SelectTypeOfCustomer();
            var customerOperation = new CustomerDbOperation<BaseCustomer>();
            customerOperation.Add(customer);
        }

        static BaseCustomer SelectTypeOfCustomer()
        {
            switch (ConfigurationManager.AppSettings.Get("AccessType"))
            {
                case "ADO":
                    return new FanshopDbADO.Customer("Rafael", "Khasanov", "8952562562", "rao1rafas@gmail.com", null);
                    break;
                case "EF":
                    return new FanshopDbEF.Customer("Ivann", "Khasanov", "8952562562", "rao2rafas@gmail.com", null);
                    break;
                case "EFCore":
                    return new FanshopDbEFCore.Customer("Petr", "Khasanov", "8952562562", "rao3rafas@gmail.com", null);
                    break;
                default:
                    return new BaseCustomer();
                    break;
            }
        }
    }
}
