using Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VehicleAPI.ApplicationContext.Config;


namespace VehicleAPI.ApplicationContext
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles{ get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buss { get; set; }
        public DbSet<Boat> Boats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new BoatObjects());
            //modelBuilder.ApplyConfiguration(new CarObjects());
            //modelBuilder.ApplyConfiguration(new BusObjects());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
