using CarRentalAPI.Domain.Entities.Common;

namespace CarRentalAPI.Domain.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CommunicationNumber { get; set; }
    }
}
