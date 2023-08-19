namespace CarRentalAPI.Domain.Entities
{
    public class City :BaseEntity
    {
        public int Name { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
