using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class Order : BaseOrder
    {
        public Order() => OrderProduct = new HashSet<OrderProduct>();
        public virtual Customer Customer { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
