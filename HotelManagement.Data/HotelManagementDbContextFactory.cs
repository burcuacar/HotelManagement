using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HotelManagement.Data
{
    public class HotelManagementDbContextFactory : IDesignTimeDbContextFactory<HotelManagementDbContext>
    {
        public HotelManagementDbContext CreateDbContext(string[] args)
        {
            // API Projesindeki appsettings.json dosyasını bul
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HotelManagement.API")) // API projesinin dizinine git
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<HotelManagementDbContext>();
            var connectionString = configuration.GetConnectionString("HotelManagementDb");

            optionsBuilder.UseSqlServer(connectionString);

            return new HotelManagementDbContext(optionsBuilder.Options);
        }
    }
}
