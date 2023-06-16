using Business.Concrete;
using Business.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using VehicleAPI.ApplicationContext;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController :ControllerBase
    {
        private readonly IVehicleRepository<Car> _vehicleRepository;
        private readonly ICarRepository _carRepository;

        public CarController(IVehicleRepository<Car> vehicleRepository, ICarRepository carRepository)
        {
            _vehicleRepository = vehicleRepository;
            _carRepository = carRepository;
        }

        [HttpGet]
        public List<Car> GetAllCars() 
        {
            var car = _carRepository.GetAll();
            return car;
        }

        [HttpGet("color")]
        public IActionResult GetColor(string color) 
        {
            var car = _carRepository.GetByColor("color");
            return Ok(car);
        }

        [HttpPost("{id}/headlights")]
        public IActionResult HeadlightsStatus(int id)
        {
            var car = _carRepository.HeadlightsStatus(id);
          return Ok(car);
            
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            var deleted = _carRepository.Delete(id);
            if (deleted)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
