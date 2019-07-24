using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class Brand : BaseBrand
    {
        public Brand() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
