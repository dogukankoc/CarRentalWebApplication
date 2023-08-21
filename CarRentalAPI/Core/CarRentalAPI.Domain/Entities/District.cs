using System.ComponentModel.DataAnnotations.Schema;
using CarRentalAPI.Domain.Entities.Common;

namespace CarRentalAPI.Domain.Entities
{
    public class District
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int CityId { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public ICollection<Office> Offices { get; set; }
    }
}
