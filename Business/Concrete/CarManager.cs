using Business.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAPI.ApplicationContext;

namespace Business.Concrete
{

    public class CarManager : VehicleRepository<Car>, ICarRepository
    {
        private readonly VehicleDbContext _vehicleDbContext;
        private readonly DbSet<Car> _dbset;

        public CarManager(VehicleDbContext vehicleDbContext) :base(vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
            _dbset = _vehicleDbContext.Set<Car>();
        }
       
        public bool Delete(int id)
        {
            var findCar = _dbset.Find(id);
            if (findCar != null)
            {
                _dbset.Remove(findCar);
                _vehicleDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Car> GetAll()
        {
            return _dbset.OrderBy(c=>c.Id).ToList();
        }
        public bool HeadlightsStatus(int id)
        {
            var findCar = _dbset.Find(id);
            if (findCar != null)
            {
                findCar.HeadlightsStatus = !findCar.HeadlightsStatus;

            }
            _vehicleDbContext.SaveChanges();

            if (findCar.HeadlightsStatus == true)
                return true;
            else 
               return false;

        }
        public Car GetByColor(string color)
        {
            return _dbset.Where(c => c.VehicleColor == color)
               .FirstOrDefault();
        }
    }
}
