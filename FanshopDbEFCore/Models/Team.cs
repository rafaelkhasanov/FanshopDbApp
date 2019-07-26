using System.Collections.Generic;

namespace FanshopDbEFCore
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string TeamCity { get; set; }
        public Team() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
