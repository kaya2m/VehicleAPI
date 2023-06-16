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
    public class BusManager :IBusRepository
    {
        private readonly VehicleDbContext _vehicleDbContext;
        private readonly DbSet<Bus> _dbSet;

        public BusManager(VehicleDbContext vehicleDbContext)
           
        {
            _vehicleDbContext = vehicleDbContext;
            _dbSet = _vehicleDbContext.Set<Bus>();
        }

        public List<Bus> GetAll()
        {
            return _dbSet.OrderBy(c => c.Id).ToList();
        }

        public List<Bus> GetByColor(string color)
        {
            var buses = _dbSet.Where(b => b.VehicleColor == color
            || (color == null && b.VehicleColor == null))
                .ToList();
            return buses;
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
