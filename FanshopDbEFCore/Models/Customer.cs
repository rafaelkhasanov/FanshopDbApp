using System.Collections.Generic;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEFCore
{
    public class Customer : BaseCustomer
    {
        public Customer() => Order = new HashSet<Order>();
        public virtual ICollection<Order> Order { get; set; }
    }
}
