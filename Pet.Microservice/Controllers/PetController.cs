using Microsoft.AspNetCore.Mvc;
using Pet.Microservice.Interfaces;
using Pet.Microservice.ViewModels;

namespace Pet.Microservice.Controllers
{
    public class PetController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IPetService _petService;


        public PetController(AppDbContext context, IPetService petService)
        {
            _context = context;
            _petService = petService;
        }

        [HttpPost("add-pet")]
        public IActionResult AddPet([FromBody] PetVM pet)
        {
            _petService.AddPet(pet);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllPets()
        {
            var pets= _petService.GetAll();
            return Ok(pets);

        }


        [HttpGet("get-by-id /{id}")]
        public IActionResult GetPetById(int id)
        {
            var _pet = _petService.PetById(id);
            return Ok(_pet);
        }

        [HttpPut("update-by-id/{Id}")]
        public IActionResult UpdatePet(int Id, [FromBody] PetVM pet)
        {
            var updatedPet = _petService.UpdatePet(Id, pet);
            return Ok(updatedPet);
        }


        [HttpDelete("delete-pet/{Id}")]
        public IActionResult DeletePet(int Id)
        {
            _petService.DeletePet(Id);
            return Ok();
        }
    }
}
