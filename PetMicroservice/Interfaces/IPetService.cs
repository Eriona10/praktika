using PetMicroservice.Data.Entieties;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Interfaces
{
    public interface IPetService
    {
        public Pet PetById(int Id);
        public List<Pet> GetAll();

        public void AddPet(Pet pet);
        public void DeletePet(int Id);
        public Pet UpdatePet(int Id, PetVM pet);
    }
}
