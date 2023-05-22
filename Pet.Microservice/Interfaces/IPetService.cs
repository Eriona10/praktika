using Pet.Microservice.Models;
using Pet.Microservice.ViewModels;

namespace Pet.Microservice.Interfaces
{
    public interface IPetService
    {

        public PetModel PetById(int Id);
        public List<PetModel> GetAll();
        public void AddPet(PetVM pet);
        public void DeletePet(int Id);
        public PetModel UpdatePet(int Id, PetVM pet);
           }
}
