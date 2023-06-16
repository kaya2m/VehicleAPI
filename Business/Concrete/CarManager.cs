using Business.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAPI.ApplicationContext;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly VehicleDbContext _vehicleDbContext;
        private readonly ICarService _carService;
        public CarManager(VehicleDbContext vehicleDbContext, ICarService carService)
        {
            _vehicleDbContext = vehicleDbContext;
            _carService = carService;
        }

        public void Create(Car car)
        {
           var CreateCar = _vehicleDbContext.Cars.Add(car);
            _vehicleDbContext.SaveChanges();
            

        }

        public void Delete(int id)
        {
            var FindCar = _vehicleDbContext.Cars.Find(id);
            var DeleteCar = _vehicleDbContext.Cars.Remove(FindCar);
            _vehicleDbContext.SaveChanges();
        }

        public List<Car> GetAllCar()
        {
            var LisToCar = _vehicleDbContext.Cars.ToList();
            return LisToCar;
        }

        public Car GetCarByColor(string color)
        {
            var findCar = _vehicleDbContext.Cars.Find(color);
            
            return findCar;
        }

        public void Update(Car car)
        {
            var find = _vehicleDbContext.Cars.Find(car);
            var updateCar = _vehicleDbContext.Cars.Update(find);
            _vehicleDbContext.SaveChanges();
           

        }
    }
}
