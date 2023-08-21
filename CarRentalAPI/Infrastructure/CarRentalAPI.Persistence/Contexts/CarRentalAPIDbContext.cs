using CarRentalAPI.Domain.Entities;
using CarRentalAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace CarRentalAPI.Persistence.Contexts
{
    public class CarRentalAPIDbContext : DbContext
    {
        public CarRentalAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        //public DbSet<BaseEntity> BaseEntity { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
