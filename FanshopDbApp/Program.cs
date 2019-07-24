using System;
using FanshopDbDataAccessLibrary.BaseModels;
using FanshopDbEF;
using FanshopDbRepo;

namespace FanshopDbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomer customer = new Customer()
            {
                FirstName = "Rafael",
                LastName = "Khasanov",
                Email = "rapraprafraf@gmail.com",
                DateOfBirth = null
            };
            var custOper = new CustomerDbOperation<BaseCustomer>();
            custOper.Add(customer);
            //Console.ReadLine();
            #region if (ConfigurationManager.ConnectionStrings["FanshopDbADO"].)
            //{

            //}
            //using (FanshopEfOperations<Customer> operCust = new FanshopEfOperations<FanshopDbEF.Customer>())
            //{
            //    FanshopDbEF.Customer customer = (FanshopDbEF.Customer)cust;
            //    operCust.Add(customer);
            //}

            //using (FanshopEfOperations<FanshopDbEFCore.Customer> operCust = new FanshopEfOperations<FanshopDbEFCore.Customer>())
            //{
            //    operCust.Add((FanshopDbEFCore.Customer)cust);
            //}

            //Console.ReadLine();

            //using (var custo = new CustomerOperationADO())
            //{
            //    custo.Add((FanshopDbADO.Customer) cust);
            //}
            //DatabaseOperation<BaseCustomer> black = new DatabaseOperation<BaseCustomer>();
            //black.Add(cust);
            #endregion
        }
    }
}
