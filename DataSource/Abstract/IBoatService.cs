using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Abstract;

public interface IBoatService
{
    ICollection<Boat> GetAllBoat();
    Boat GetBoatById(int id);
    Boat GetBoatByColor(string color);
    Boat Create(Boat boat);
    Boat Update(Boat boat);
    void Delete(int id);
}
