using FanshopDbDataAccessLibrary.BaseModels.BaseEntity;

namespace FanshopDbDataAccessLibrary.Interface
{
    public interface IDbOperations
    {
        void AddNewRecord(BaseEntity entity);
    }
}