using System.Collections.Generic;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEFCore
{
    public class Category : BaseCategory
    {
        public Category() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
