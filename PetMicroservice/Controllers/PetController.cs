using Microsoft.AspNetCore.Mvc;
using PetMicroservice.Data.Entieties;
using PetMicroservice.Interfaces;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Controllers
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
     
        [HttpPost("add-pet")]
        [ProducesResponseType(typeof(AddPetResponse), 200)]
        public IActionResult AddPet([FromForm] Pet pet, IFormFile file)
        {
            // Validate the pet data and perform necessary checks

            // Create a new instance of the PetModel and populate its properties
            var petModel = new Pet
            {
                // Assign properties from the PetVM object
                // ...

                // Set the pet image properties
                Name = pet.Name,
                Age = pet.Age,
                Birthday = pet.Birthday,
                Gender = pet.Gender,
                Breed = pet.Breed,
                Weight = pet.Weight,
                Height = pet.Height,
                AnimalType = pet.AnimalType,
                UserId = pet.UserId,
             
                ImagePath = pet.ImagePath ?? "C:\\Users\\PC\\Desktop\\lab2Images", // Set the desired image path here
            
                ImageName = file.FileName,
                ImageType = file.ContentType
            };

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
        public IActionResult GetAllPet()
        {
            var pet = _petService.GetAll();
            return Ok(pet);

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
            return Ok("Kafsha eshte fshrire");
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
    }
}
