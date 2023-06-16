using Business.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private readonly IBusRepository _busRepository;
        private readonly IBoatRepository _boatRepository;

        public VehicleController(ICarRepository carRepository
            , IBusRepository busRepository
            , IBoatRepository boatRepository)
        {
            _carRepository = carRepository;
            _busRepository = busRepository;
            _boatRepository = boatRepository;
        }
        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var cars = _carRepository.GetAll();
            var buses = _busRepository.GetAll();
            var boats = _boatRepository.GetAll();

            var allVehicles = new List<Vehicle>();
            allVehicles.AddRange(cars);
            allVehicles.AddRange(buses);
            allVehicles.AddRange(boats);

            return Ok(allVehicles);
        }
        [HttpGet("color")]
        public IActionResult GetVehiclesByColor(string color)
        {
            var cars = _carRepository.GetAll().Where(c => c.VehicleColor == color);
            var buses = _busRepository.GetAll().Where(c => c.VehicleColor == color);
            var boats = _boatRepository.GetAll().Where(c => c.VehicleColor == color);

            var allVehicles = new List<Vehicle>();
            allVehicles.AddRange(cars);
            allVehicles.AddRange(buses);
            allVehicles.AddRange(boats);

            return Ok(allVehicles);
        }

        
    }
}
