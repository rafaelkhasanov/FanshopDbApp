using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public Color() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
