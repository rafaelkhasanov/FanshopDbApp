
namespace FanshopDbDataAccessLibrary.BaseModels
{
    public class BaseOrderStatus : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
    }
}
