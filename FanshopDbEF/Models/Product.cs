namespace FanshopDbEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }

        public Guid Code { get; set; }

        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        public int CategoryId { get; set; }

        public int BrandId { get; set; }

        public int TeamId { get; set; }

        public int ColorId { get; set; }

        [StringLength(3)]
        public string Size { get; set; }

        public bool InStock { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public byte Gender { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }

        public virtual Color Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public virtual Team Team { get; set; }
    }
}
