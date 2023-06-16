using Entities;

namespace Business.Interfaces
{
    public interface ICarRepository : IVehicleRepository<Car>
    {
        bool HeadlightsStatus(int id);
    }
}
