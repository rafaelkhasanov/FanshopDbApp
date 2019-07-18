using FanshopDbDataAccessLibrary.BaseModels;

namespace FanshopDbEFCore
{
    public class OrderProduct : BaseOrderProduct
    {
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
