using Entities;

namespace Business.Interfaces
{
    public interface IBusRepository : IVehicleRepository<Bus>
    {
        Bus GetByColor(string color);
    }
}
