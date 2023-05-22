using Pet.Microservice.Interfaces;
using Pet.Microservice.ViewModels;
using Pet.Microservice.Models;
using static Pet.Microservice.Services.PetService;

namespace Pet.Microservice.Services
{
    public class PetService : IPetService
    {

            private readonly AppDbContext _context;

            public PetService(AppDbContext context)
            {
                _context = context;
            }



        public void AddPet(PetVM pet)
        {
            var _pet = new PetModel()
            {

                name=pet.name, 
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
            throw new NotImplementedException();
        }

        public List<PetModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PetModel PetById(int Id)
        {
            throw new NotImplementedException();
        }

        public PetModel UpdatePet(int Id, PetVM pet)
        {
            throw new NotImplementedException();
        }
    }
}
