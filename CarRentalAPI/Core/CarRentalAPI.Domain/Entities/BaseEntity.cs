namespace CarRentalAPI.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
