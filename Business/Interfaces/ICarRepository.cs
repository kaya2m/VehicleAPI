using Entities;

namespace Business.Interfaces
{
    public interface ICarRepository : IVehicleRepository<Car>
    {

        Car GetByColor(string color);
        bool HeadlightsStatus(int id);
    }
}
