using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public Brand() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
