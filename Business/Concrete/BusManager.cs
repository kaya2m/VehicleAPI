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
    public class BusManager : VehicleRepository<Bus>, IBusRepository
    {
        private readonly VehicleDbContext _vehicleDbContext;
        private readonly DbSet<Bus> _dbSet;

        public BusManager(VehicleDbContext vehicleDbContext)
            :base (vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
            _dbSet = _vehicleDbContext.Set<Bus>();
        }

        public List<Bus> GetAll()
        {
            return _dbSet.OrderBy(c => c.Id).ToList();
        }

        public Bus GetByColor(string color)
        {
            return _dbSet.Where(c => c.VehicleColor == color)
               .FirstOrDefault();
        }

        public bool Delete(int id)
        {
            var findCar = _dbSet.Find(id);
            if (findCar != null)
            {
                _dbSet.Remove(findCar);
                _vehicleDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
