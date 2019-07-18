using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEF
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public class Order : BaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order() => OrderProducts = new HashSet<OrderProduct>();

        [Required]
        [StringLength(120)]
        public string Address { get; set; }

        [StringLength(300)]
        public string Comment { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
