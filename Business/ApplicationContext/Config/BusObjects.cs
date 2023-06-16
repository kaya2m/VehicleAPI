using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VehicleAPI.ApplicationContext.Config
{
    public class BusObjects : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasData(
                new Bus { Id = 9, VehicleType = "Bus", VehicleColor = "red", Capacity = 36 },
                new Bus { Id = 10, VehicleType = "Bus", VehicleColor = "white", Capacity = 26 },
                new Bus { Id = 11, VehicleType = "Bus", VehicleColor = "black", Capacity = 12 },
                new Bus { Id = 12, VehicleType = "Bus", VehicleColor = "blue", Capacity = 19 }
                );
        }
    }
}
