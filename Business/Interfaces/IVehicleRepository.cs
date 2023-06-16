using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IVehicleRepository<T>
    {
        List<T> GetAll();
        List<T> GetByColor(string color);
        bool Delete(int id);
       
    }
}
