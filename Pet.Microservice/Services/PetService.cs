using Pet.Microservice.Interfaces;
using Pet.Microservice.ViewModels;
using Pet.Microservice.Models;
using static Pet.Microservice.Services.PetService;
using Pet.Microservice.Data;

namespace Pet.Microservice.Services
{
    public class PetService : IPetService
    {
        private readonly PetDbContext _context;


        public PetService(PetDbContext context)
        {
            _context = context;
        }

        public void AddPet(PetModel pet)
        {
            var _pet = new PetModel()
            {
                name = !string.IsNullOrEmpty(pet.name) ? pet.name : "Unknown",
                age = pet.age != null && pet.age > 0 ? pet.age : 0,
                birthday = pet.birthday != null ? pet.birthday : DateTime.Today,
                gender = !string.IsNullOrEmpty(pet.gender) ? pet.gender : "Unknown",
                breed = !string.IsNullOrEmpty(pet.breed) ? pet.breed : "Unknown",
                weight = pet.weight != null && pet.weight > 0 ? pet.weight : 0,
                height = pet.height != null && pet.height > 0 ? pet.height : 0,
                animalType = !string.IsNullOrEmpty(pet.animalType) ? pet.animalType : "Unknown",
                ImageName = pet.ImageName,
                ImagePath = pet.ImagePath ?? "C:\\Users\\NB\\Desktop\\lab2Images", // Set the desired image path here
                ImageType = pet.ImageType
            };

            _context.Pets.Add(_pet);
            _context.SaveChanges();
        }






        public void DeletePet(int Id)
        {
            var pet = _context.Pets.Find(Id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                _context.SaveChanges();
            }
        }

        public List<PetModel> GetAll()
        {
            return _context.Pets.ToList();
        }

        public PetModel PetById(int Id)
        {
            return _context.Pets.Find(Id);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public PetModel UpdatePet(int Id, PetVM pet)
        {
            var existingPet = _context.Pets.Find(Id);
            if (existingPet != null)
            {
                existingPet.name = pet.name;
                existingPet.age = pet.age;
                existingPet.birthday = DateTime.Parse(pet.birthday); ;
                existingPet.gender = pet.gender;
                existingPet.breed = pet.breed;
                existingPet.weight = pet.weight;
                existingPet.height = pet.height;
                existingPet.animalType = pet.animalType;

                _context.SaveChanges();
            }
            else
            {
                // Handle the scenario when the pet with the given Id is not found
                // For example, you can throw an exception or return a specific value
                // based on your application's requirements.
                // Here's an example of throwing an exception:
                throw new Exception($"Pet with Id {Id} not found.");
            }

            return existingPet;
        }
    }
}

