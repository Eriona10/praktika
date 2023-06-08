using Microsoft.EntityFrameworkCore;
using PetMicroservice.Data.Entieties;
using PetMicroservice.Interfaces;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Services
{
    public class PetService : IPetService
    {
        private readonly PetTrackerContext _context;

        public PetService(PetTrackerContext context)
        {
            _context = context;
        }
        public void AddPet(Pet pet)
        {
            var _pet = new Pet()
            {
                //Name = !string.IsNullOrEmpty(pet.Name) ? pet.Name : "Unknown",
                //Age = pet.Age != null && pet.Age > 0 ? pet.Age : 0,
                //Birthday = pet.Birthday != null ? pet.Birthday : DateTime.Today,
                //Gender = !string.IsNullOrEmpty(pet.Breed) ? pet.Breed : "Unknown",
                //Breed = !string.IsNullOrEmpty(pet.Breed) ? pet.Breed : "Unknown",
                //Weight = pet.Weight != null && pet.Weight > 0 ? pet.Weight : 0,
                //Height = pet.Height != null && pet.Height > 0 ? pet.Height : 0,
                //AnimalType = !string.IsNullOrEmpty(pet.AnimalType) ? pet.AnimalType : "Unknown",
                Name= pet.Name,
                Age=pet.Age,
                Birthday=pet.Birthday,
                Gender=pet.Gender,
                Breed=pet.Breed,
                Weight=pet.Weight,
                Height=pet.Height,
                AnimalType=pet.AnimalType,
                UserId = pet.UserId,
                ImageName = pet.ImageName,
                ImagePath = pet.ImagePath ?? "C:\\Users\\PC\\Desktop\\lab2Images", // Set the desired image path here
                ImageType = pet.ImageType
            };

            _context.Pet.Add(_pet);
            _context.SaveChanges();
        }

        public void DeletePet(int Id)
        {
            var pet = _context.Pet.Find(Id);
            if (pet != null)
            {
                _context.Pet.Remove(pet);
                _context.SaveChanges();
            }
        }

        public List<Pet> GetAll()
        {
            return _context.Pet.ToList();
        }

        public Pet PetById(int Id)
        {
            return _context.Pet.Find(Id);
        }
        public Pet UpdatePet(int Id, PetVM pet)
        {
            var existingPet = _context.Pet.Find(Id);
            if (existingPet != null)
            {
                existingPet.Name = pet.Name;
                existingPet.Age = pet.Age;
                existingPet.Birthday = pet.Birthday;
                existingPet.Gender = pet.Gender;
                existingPet.Breed = pet.Breed;
                existingPet.Weight = pet.Weight;
                existingPet.Height = pet.Height;
                existingPet.AnimalType = pet.AnimalType;
                existingPet.UserId = pet.UserId;

                _context.SaveChanges();
            }
            else
            {
                throw new Exception($"Pet with Id {Id} not found.");
            }

            return existingPet;
        }
    }
}
