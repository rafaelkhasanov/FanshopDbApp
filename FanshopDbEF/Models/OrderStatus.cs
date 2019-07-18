using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEF
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class OrderStatus : BaseOrderStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderStatus() => Orders = new HashSet<Order>();

        [Required]
        [StringLength(40)]
        public string StatusName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
