using Business.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoatController :ControllerBase
    {
        private readonly IVehicleRepository<Boat> _vehicleRepository;
        private readonly IBoatRepository _boatRepository;

        public BoatController(IVehicleRepository<Boat> vehicleRepository, IBoatRepository boatRepository)
        {
            _vehicleRepository = vehicleRepository;
            _boatRepository = boatRepository;
        }

        [HttpGet]
        public List<Boat> GetAllBoat()
        {
            var boat = _boatRepository.GetAll();
            return boat;
        }
        [HttpGet("color")]
        public IActionResult GetColor(string color)
        {
            //var boat = _boatRepository.GetByColor("color");
            //return boat;

            var boats = _boatRepository.GetAll().Where(c => c.VehicleColor == color);

            var allSameBoats = new List<Boat>();
            allSameBoats.AddRange(boats);
            return Ok(allSameBoats);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBus(int id)
        {
            var deleted = _boatRepository.Delete(id);
            if (deleted)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
