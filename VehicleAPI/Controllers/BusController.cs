
using Microsoft.AspNetCore.Mvc;
using VehicleAPI.ApplicationContext;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusController : ControllerBase
    {
        private readonly VehicleDbContext _vehicleDbContext;

        public BusController(VehicleDbContext vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
        }

        [HttpGet]
        public IActionResult GetAllBus()
        {
            var buses = _vehicleDbContext.Buss.ToList();
            return Ok(buses);
        }
        [HttpGet("color")]
        public IActionResult GetBusByByColor(string color)
        {
            var buses = _vehicleDbContext.Buss.Select(b => b.VehicleColor == color);
            return Ok(buses);

        }
        [HttpDelete("id")]
        public IActionResult DeleteBus(int id)
        {
            var findC = _vehicleDbContext.Buss.Find(id);
            var buses = _vehicleDbContext.Buss.Remove(findC);
            return Ok(buses);
        }
       
    }
}
