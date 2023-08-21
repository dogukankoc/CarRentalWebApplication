using CarRentalAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace CarRentalAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarRentalAPIDbContext>
    {
        public CarRentalAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CarRentalAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new CarRentalAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
