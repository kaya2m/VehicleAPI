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
    public class BoatManager : VehicleRepository<Boat>, IBoatRepository
    {
        private readonly VehicleDbContext _context;
        private readonly DbSet<Boat> _dbSet;

        public BoatManager(VehicleDbContext context)
            : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Boat>();
        }
        public List<Boat> GetAll()
        {
            return _dbSet.OrderBy(c => c.Id).ToList();
        }

        public Boat GetByColor(string color)
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
                    _context.SaveChanges();
                    return true;
                }
                return false;
            
        }
    }
}
