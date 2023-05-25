using Pet.Microservice.Interfaces;
using Pet.Microservice.ViewModels;
using Pet.Microservice.Models;
using static Pet.Microservice.Services.PetService;

namespace Pet.Microservice.Services
{
    public class PetService : IPetService
    {
        private readonly PetDbContext _context;

        public PetService(PetDbContext context)
        {
            _context = context;
        }

        public void AddPet(PetVM pet)
        {
            var _pet = new PetModel()
            {
                name = pet.name,
                age = pet.age,
                birthday = pet.birthday,
                gender = pet.gender,
                breed = pet.breed,
                weight = pet.weight,
                height = pet.height,
                animalType = pet.animalType
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

        public PetModel UpdatePet(int Id, PetVM pet)
        {
            var existingPet = _context.Pets.Find(Id);
            if (existingPet != null)
            {
                existingPet.name = pet.name;
                existingPet.age = pet.age;
                existingPet.birthday = pet.birthday;
                existingPet.gender = pet.gender;
                existingPet.breed = pet.breed;
                existingPet.weight = pet.weight;
                existingPet.height = pet.height;
                existingPet.animalType = pet.animalType;

                _context.SaveChanges();
            }

            return existingPet;
        }
    }
}
