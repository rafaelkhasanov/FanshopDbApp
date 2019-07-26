using System;
using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte DeliveryType { get; set; }
        public string Comment { get; set; }
        public decimal? TotalPrice { get; set; }
        public byte PaymentType { get; set; }
        public Order() => OrderProduct = new HashSet<OrderProduct>();
        public virtual Customer Customer { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
