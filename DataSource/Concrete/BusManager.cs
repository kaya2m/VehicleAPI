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
    public class BusManager : IBusService
    {
        private readonly BusRepository _busRepository;

        public BusManager(BusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public Bus Create(Bus bus)
        {
            return _busRepository.Create(bus);
        }

        public void Delete(int id)
        {
            _busRepository.Delete(id);
        }

        public List<Bus> GetAllBus()
        {
           return _busRepository.GetAllBus();
        }

        public Bus GetBusByColor(string color)
        {
            return _busRepository.GetBusByColor(color);
        }

        public Bus GetBusById(int id)
        {
            return _busRepository.GetBusById(id);
        }

        public Bus Update(Bus bus)
        {
            return _busRepository.Update(bus);
        }
    }
}
