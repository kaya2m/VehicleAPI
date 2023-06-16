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
    public class VehicleRepository<T>: IVehicleRepository<T> where T : class
    {
        private readonly VehicleDbContext _vehicleDbContext;
        private readonly DbSet<T> _dbset;

        public VehicleRepository(VehicleDbContext vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
            _dbset = _vehicleDbContext.Set<T>();
        }

        public void Delete(int id)
        {
            var FindCar = _dbset.Find(id);
            if (FindCar != null)
            {
                _dbset.Remove(FindCar);
                _vehicleDbContext.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            return _dbset.ToList();
        }

        public List<T> GetByColor(string color)
        {
            var findColor = _dbset.Where(v=>v.Equals(color)).ToList();
            return findColor;
        }

        bool IVehicleRepository<T>.Delete(int id)
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
    }
}
