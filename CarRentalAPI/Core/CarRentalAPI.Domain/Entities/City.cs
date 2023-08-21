using CarRentalAPI.Domain.Entities.Common;

namespace CarRentalAPI.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int Name { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
