namespace CarRentalAPI.Domain.Entities
{
    public class District : BaseEntity
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public ICollection<Office> Offices { get; set; }
    }
}
