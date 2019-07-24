using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class Category : BaseCategory
    {
        public Category() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
