using Entities;

namespace Business.Interfaces
{
    public interface IBoatRepository : IVehicleRepository<Boat>
    {
        Boat GetByColor(string color);
    }
}
