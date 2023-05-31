using Location.Microservice.Data.Entieties;
using Location.Microservice.Interfaces;
using Location.Microservice.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Location.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly PetTrackerContext _context;
        private readonly ILocationServices _locationService;


        public LocationController(PetTrackerContext context, ILocationServices locationService)
        {
            _context = context;
            _locationService = locationService;
        }

        [HttpPost("add-location")]
        public IActionResult AddLocation([FromBody] Locations location)
        {
            _locationService.AddLocation(location);
            return Ok("Kafsha u regjistru");
        }
        //public async Task<ActionResult<List<Location>>> AddLocation(Location location)
        //{
        //    _context.Location.Add(location);
        //    await _context.SaveChangesAsync();

        //    return Ok(await _context.Location.ToListAsync());
        //}
        [HttpGet]
        public IActionResult GetAllLocation()
        {
            var location = _locationService.GetAll();
            return Ok(location);

        }


        [HttpGet("get-by-id /{id}")]
        public IActionResult GetPetById(int id)
        {
            var _pet = _locationService.LocationById(id);
            return Ok(_pet);
        }

        [HttpPut("update-by-id/{Id}")]
        public IActionResult UpdatePet(int Id, [FromBody] LocationVm location)
        {
            var updatedPet = _locationService.UpdateLocation(Id, location);
            return Ok(updatedPet);
        }


        [HttpDelete("delete-location/{Id}")]
        public IActionResult DeletePet(int Id)
        {
            _locationService.DeleteLocation(Id);
            return Ok("Kafsha eshte fshrire");
        }
    }
}

