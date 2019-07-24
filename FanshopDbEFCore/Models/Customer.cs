using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class Customer : BaseCustomer
    {
        public Customer() => Order = new HashSet<Order>();
        public virtual ICollection<Order> Order { get; set; }
    }
}
