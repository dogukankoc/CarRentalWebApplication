namespace CarRentalAPI.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string GSM { get; set; }
        public string IdentityNumber { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string ImagePath { get; set; }
    }
}
