
using System.ComponentModel;

namespace FanshopBaseData.BaseModels
{
    public class BaseOrderProduct : BaseEntity.BaseEntity
    {
        [Browsable(false)]
        private new int Id {get; set;}
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CountProduct { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Total { get; set; }
    }
}
