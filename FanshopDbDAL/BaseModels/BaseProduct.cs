using System;

namespace FanshopDbDataAccessLibrary.BaseModels
{
    public class BaseProduct : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int TeamId { get; set; }
        public int ColorId { get; set; }
        public string Size { get; set; }
        public bool InStock { get; set; }
        public decimal Price { get; set; }
        public byte Gender { get; set; }
    }
}
