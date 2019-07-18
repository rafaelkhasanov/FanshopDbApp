using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEF
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Team")]
    public class Team : BaseTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team() => Products = new HashSet<Product>();

        [Required]
        [StringLength(30)]
        public string TeamName { get; set; }

        [Required]
        [StringLength(20)]
        public string TeamCity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
