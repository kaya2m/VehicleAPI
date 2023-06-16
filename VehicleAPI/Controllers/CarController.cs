using Business.Concrete;
using Business.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController :ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAllCars() 
        {
            var response = _carService.GetAllCar();
            return Ok(response);
        }
       
    }
}
