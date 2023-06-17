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
                new Car { Id = 1, VehicleType = "Car", VehicleColor = "blue", HeadlightsStatus = true,Wheels=4},
               new Car { Id = 2, VehicleType = "Car", VehicleColor = "red", HeadlightsStatus = true,Wheels = 6 },
               new Car { Id = 3, VehicleType = "Car", VehicleColor = "white", HeadlightsStatus = true,Wheels = 4 },
               new Car { Id = 4, VehicleType = "Car", VehicleColor = "black", HeadlightsStatus = true,Wheels=8 },
                new Car { Id = 36, VehicleType = "Car", VehicleColor = "blue", HeadlightsStatus = true, Wheels = 4 },
               new Car { Id = 37, VehicleType = "Car", VehicleColor = "red", HeadlightsStatus = true, Wheels = 6 },
               new Car { Id = 38, VehicleType = "Car", VehicleColor = "white", HeadlightsStatus = true, Wheels = 4 },
               new Car { Id = 39, VehicleType = "Car", VehicleColor = "black", HeadlightsStatus = true, Wheels = 8 }
               );
        }
    }
}
