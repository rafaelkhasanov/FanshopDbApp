using System;
using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class Product
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int TeamId { get; set; }
        public int ColorId { get; set; }
        public string Size { get; set; }
        public bool InStock { get; set; }
        public decimal Price { get; set; }
        public byte Gender { get; set; }
        public Product() => OrderProduct = new HashSet<OrderProduct>();
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
