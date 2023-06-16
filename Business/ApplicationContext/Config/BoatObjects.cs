using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VehicleAPI.ApplicationContext.Config
{
    public class BoatObjects : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.HasData(
                new Boat { Id = 5, VehicleType = "Boat", VehicleColor = "blue", MaxSpeed = 100 },
                new Boat { Id = 6, VehicleType = "Boat", VehicleColor = "red", MaxSpeed = 123 },
                new Boat { Id = 7, VehicleType = "Boat", VehicleColor = "black", MaxSpeed = 142 },
                new Boat { Id = 8, VehicleType = "Boat", VehicleColor = "white", MaxSpeed = 154 }
                );

        }
    }
}
