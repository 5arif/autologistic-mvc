using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AutoLogistic.Models;
using AutoLogistic.Models.Master;
using AutoLogistic.Models.Transactions;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace AutoLogistic.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasPostgresExtension("uuid-ossp");

            //builder.Entity<Carrier>().Property(e => e.CarrierId).HasDefaultValueSql("uuid_generate_v4()");

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Carrier>    Carrier    { get; set; }
        public DbSet<City>       City       { get; set; }
        public DbSet<CrType>     CrType     { get; set; }
        public DbSet<Customer>   Customer   { get; set; }
        public DbSet<Driver>     Driver     { get; set; }
        public DbSet<ItemColor>  ItemColor  { get; set; }
        public DbSet<ItemModel>  ItemModel  { get; set; }
        public DbSet<ItemType>   ItemType   { get; set; }
        public DbSet<PickupArea> PickupArea { get; set; }
        public DbSet<RackPole>   RackPole   { get; set; }
        public DbSet<Truck>      Truck      { get; set; }
        public DbSet<Trucker>    Trucker    { get; set; }
        public DbSet<Wellbase>   Wellbase   { get; set; }
        
        public DbSet<Receiving>  Receiving  { get; set; }
        public DbSet<Delivering> Delivering { get; set; }
        public DbSet<Shipping>   Shipping   { get; set; }
    }
}
