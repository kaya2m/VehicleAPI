using Business.Manager;
using DataSource.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Concrete
{
    public class CarManager : ICarService
    {
        private readonly CarRepository _carRepository;

        public CarManager(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car CreateCar(Car car)
        {
            return _carRepository.CreateCar(car);
        }

        public void Delete(int id)
        {
            _carRepository.Delete(id);
        }

        public List<Car> GetAllCar()
        {
            return _carRepository.GetAllCar();
        }

        public Car GetCarByColor(string color)
        {
            return _carRepository.GetCarByColor(color);
        }

        public Car GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }

        public Car UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }
    }
}
