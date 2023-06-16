using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCar();
        Car GetCarById(int id);
        Car GetCarByColor(string color);
        Car CreateCar(Car car);
        Car UpdateCar(Car car);
        void Delete(int id);
    }
}
