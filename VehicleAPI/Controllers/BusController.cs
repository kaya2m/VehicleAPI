﻿
using Business.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;
using VehicleAPI.ApplicationContext;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusController : ControllerBase
    {
        private readonly IVehicleRepository<Bus> _vehicleRepository;
        private readonly IBusRepository _busRepository;

        public BusController(IVehicleRepository<Bus> vehicleRepository, IBusRepository busRepository)
        {
            _vehicleRepository = vehicleRepository;
            _busRepository = busRepository;
        }

        [HttpGet]
        public List<Bus> GetAllBus()
        {
            var bus = _busRepository.GetAll();
            return bus;
        }

        [HttpGet("color")]
        public IActionResult GetColor(string color)
        {
            var bus = _busRepository.GetByColor("color");
            return Ok(bus);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBus(int id)
        {
            var deleted = _busRepository.Delete(id);
            if (deleted)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
