using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICarService
    {
        List<Car>GetAllCar();
        Car GetCarByColor(string color);
        void Create(Car car);
        void Update(Car car);
        void Delete(int id);

    }
}
