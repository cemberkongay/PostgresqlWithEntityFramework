using Microsoft.EntityFrameworkCore;
using Hub.Entities;

namespace Hub.DataAccess
{
    public class HubDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;Database=Hub;Username=hubDb;Password=hubDb2020!!;");
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }

}

