using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VehicleAPI.ApplicationContext.Config
{
    public class CarObjects : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                new Car { Id = 1, VehicleType = "Car", VehicleColor = "blue", HeadlightsStatus = true },
               new Car { Id = 2, VehicleType = "Car", VehicleColor = "red", HeadlightsStatus = true },
               new Car { Id = 3, VehicleType = "Car", VehicleColor = "white", HeadlightsStatus = true },
               new Car { Id = 4, VehicleType = "Car", VehicleColor = "black", HeadlightsStatus = true }
               );
        }
    }
}
