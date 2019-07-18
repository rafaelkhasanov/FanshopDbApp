using System.Collections.Generic;
using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEFCore
{
    public class Team : BaseTeam
    {
        public Team() => Product = new HashSet<Product>();
        public virtual ICollection<Product> Product { get; set; }
    }
}
