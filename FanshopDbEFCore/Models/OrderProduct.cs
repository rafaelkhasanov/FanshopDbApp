namespace FanshopDbEFCore
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CountProduct { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Total { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
