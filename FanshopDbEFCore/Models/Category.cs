using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public Category() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
