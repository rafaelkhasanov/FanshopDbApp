namespace FanshopDbDataAccessLibrary.BaseModels
{
    public class BaseTeam : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string TeamCity { get; set; }
    }
}
