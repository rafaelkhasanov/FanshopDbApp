
using FanshopBaseData.BaseModels;

namespace FanshopDbADO
{
    public class OrderProduct : BaseOrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CountProduct { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Total { get; set; }
    }
}
