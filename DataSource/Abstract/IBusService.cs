using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Abstract
{
    public interface IBusService
    {
        List<Bus> GetAllBus();
        Bus GetBusById(int id);
        Bus GetBusByColor(string color);
        Bus Create(Bus bus);
        Bus Update(Bus bus);
        void Delete(int id);

    }
}
