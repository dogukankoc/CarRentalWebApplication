using CarRentalAPI.Domain.Entities.Common;

namespace CarRentalAPI.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string GSM { get; set; }
        public string IdentityNumber { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImagePath { get; set; }
    }
}
