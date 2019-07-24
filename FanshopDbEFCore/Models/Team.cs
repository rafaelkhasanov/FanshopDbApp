using System.Collections.Generic;
using FanshopBaseData.BaseModels;

namespace FanshopDbEFCore
{
    public class Team : BaseTeam
    {
        public Team() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
