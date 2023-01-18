using Microsoft.EntityFrameworkCore;
using Realty.Domain.Model;
using System.Reflection;
using System.Reflection.Metadata;

namespace Realty.Persistence
{
    public class RealtyDbContext : DbContext
    {
        public DbSet<RealtyRentAd> RealtyRentAds { get; set; }

        public DbSet<LocationDetails> Locations { get; set; }

        public DbSet<ContactDetails> Contacts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}