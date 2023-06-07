using Microsoft.AspNetCore.Mvc;
using Pet.Microservice.Data;
using Pet.Microservice.Interfaces;
using Pet.Microservice.Models;
using Pet.Microservice.ViewModels;

namespace Pet.Microservice.Controllers
{
    [ApiController]
    [Route("api/pets")]
    public class PetController : ControllerBase
    {
        private readonly PetDbContext _context;
        private readonly IPetService _petService;

        public PetController(PetDbContext context, IPetService petService)
        {
            _context = context;
            _petService = petService;
        }


        [HttpPost("add-pet")]
        [ProducesResponseType(typeof(AddPetResponse), 200)]
        public IActionResult AddPet([FromForm] PetVM pet, IFormFile file)
        {
            // Validate the pet data and perform necessary checks

            // Create a new instance of the PetModel and populate its properties
            var petModel = new PetModel
            {
                // Assign properties from the PetVM object
                // ...

                // Set the pet image properties
                ImageName = file.FileName,
                ImageType = file.ContentType
            };

            // Save the pet data to the database using the PetService
            _petService.AddPet(petModel);

            // Upload the image file
            string folderPath = @"C:\Users\NB\Desktop\lab2Images";
            string imageName = file.FileName;
            string imagePath = Path.Combine(folderPath, imageName);

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            var response = new AddPetResponse { Message = "Pet added successfully" };
            return Ok(response);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<PetModel>), 200)]
        public IActionResult GetAll()
        {
            var pets = _petService.GetAll();
            return Ok(pets);
        }

        [HttpGet("get-by-id/{id}")]
        [ProducesResponseType(typeof(PetModel), 200)]
        public IActionResult GetPetById(int id)
        {
            var pet = _petService.PetById(id);
            return Ok(pet);
        }

        [HttpPut("update-by-id/{Id}")]
        [ProducesResponseType(typeof(UpdatePetResponse), 200)]
        public IActionResult UpdatePet(int Id, [FromBody] PetVM pet)
        {
            var updatedPet = _petService.UpdatePet(Id, pet);
            var response = new UpdatePetResponse { Message = "Pet updated successfully", UpdatedPet = updatedPet };
            return Ok(response);
        }

        [HttpDelete("delete-pet/{Id}")]
        [ProducesResponseType(typeof(DeletePetResponse), 200)]
        public IActionResult DeletePet(int Id)
        {
            _petService.DeletePet(Id);
            var response = new DeletePetResponse { Message = "Pet deleted successfully" };
            return Ok(response);
        }
    }
}

public class AddPetResponse
{
    public string Message { get; set; }
}

public class UpdatePetResponse
{
    public string Message { get; set; }
    public PetModel UpdatedPet { get; set; }
}

public class DeletePetResponse
{
    public string Message { get; set; }
}