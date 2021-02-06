using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (local);Database = ReCap;Trusted_Connection=true");
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Colors> Colors { get; set; }

    }
}
