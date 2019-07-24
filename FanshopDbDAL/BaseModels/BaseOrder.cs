using System;

namespace FanshopBaseData.BaseModels
{
    public class BaseOrder : BaseEntity.BaseEntity
    {
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte DeliveryType { get; set; }
        public string Comment { get; set; }
        public decimal? TotalPrice { get; set; }
        public byte PaymentType { get; set; }
    }
}
