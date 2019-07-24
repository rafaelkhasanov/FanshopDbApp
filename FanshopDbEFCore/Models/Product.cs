using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class Product : BaseProduct
    {
        public Product() => OrderProduct = new HashSet<OrderProduct>();
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
