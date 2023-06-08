using Microsoft.AspNetCore.Mvc;
using PetMicroservice.Data.Entieties;
using PetMicroservice.Interfaces;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : Controller
    {
        private readonly PetTrackerContext _context;
        private readonly ITemperatureServices _temperatureService;


        public TemperatureController(PetTrackerContext context, ITemperatureServices temperatureService)
        {
            _context = context;
            _temperatureService = temperatureService;
        }

        [HttpPost("add-temperature")]
        public IActionResult AddTemperature([FromBody] Temperature temperature)
        {
            _temperatureService.AddTemperature(temperature);
            return Ok("Temperature  u regjistru");
        }
        //public async Task<ActionResult<List<Temperature >>> AddTemperature (Temperature  temperature)
        //{
        //    _context.Temperature .Add(temperature);
        //    await _context.SaveChangesAsync();

        //    return Ok(await _context.Temperature.ToListAsync());
        //}
        [HttpGet]
        public IActionResult GetAllTemperature()
        {
            var temperature = _temperatureService.GetAll();
            return Ok(temperature);

        }


        [HttpGet("get-by-id /{id}")]
        public IActionResult GetTemperatureById(int id)
        {
            var _temperature = _temperatureService.TemperatureById(id);
            return Ok(_temperature);
        }

        [HttpPut("update-by-id/{Id}")]
        public IActionResult UpdateTemperature(int Id, [FromBody] TemperatureVm temperature)
        {
            var updatedTemperature = _temperatureService.UpdateTemperature(Id, temperature);
            return Ok(updatedTemperature);
        }


        [HttpDelete("delete-temperature{Id}")]
        public IActionResult DeleteTemperature(int Id)
        {
            _temperatureService.DeleteTemperature(Id);
            return Ok("Temperature eshte fshrire");
        }
    }
}