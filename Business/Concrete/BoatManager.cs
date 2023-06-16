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
    public class BoatManager : IBoatRepository
    {
        private readonly VehicleDbContext _context;
        private readonly DbSet<Boat> _dbSet;

        public BoatManager(VehicleDbContext context)
            
        {
            _context = context;
            _dbSet = _context.Set<Boat>();
        }
        public List<Boat> GetAll()
        {
            return _dbSet.OrderBy(c => c.Id).ToList();
        }

   
        public bool Delete(int id)
        {
          
                var findCar = _dbSet.Find(id);
                if (findCar != null)
                {
                    _dbSet.Remove(findCar);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            
        }

        public List<Boat> GetByColor(string color)
        {
            var boat = _dbSet.Where(b => b.VehicleColor == color).ToList();
            return boat;
        }
    }
}
