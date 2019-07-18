using System.Collections.Generic;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEFCore
{
    public class Color : BaseColor
    {
        public Color() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
