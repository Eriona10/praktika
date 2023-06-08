using Microsoft.AspNetCore.Mvc;
using Pet.Microservice.Data.Entieties;
using Pet.Microservice.Interfaces;

namespace Pet.Microservice.Controllers
{
    public class PetController : Controller
    {
        private readonly PetTrackerContext _context;
        private readonly IPetService _petService;


        public PetController(PetTrackerContext context, IPetService petService)
        {
            _context = context;
            _petService = petService;
        }

        [HttpGet]
        public IActionResult GetAllLocation()
        {
            var location = _petService.GetAll();
            return Ok(location);

        }
    }
}
