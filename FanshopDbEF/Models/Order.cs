namespace FanshopDbEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order() => OrderProducts = new HashSet<OrderProduct>();

        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int StatusId { get; set; }

        [Required]
        [StringLength(120)]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public byte DeliveryType { get; set; }

        [StringLength(300)]
        public string Comment { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        public byte PaymentType { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
