namespace CarRentalAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
