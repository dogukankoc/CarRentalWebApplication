namespace CarRentalAPI.Domain.Entities
{
    public class Office : BaseEntity
    {
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CommunicationNumber { get; set; }
    }
}
