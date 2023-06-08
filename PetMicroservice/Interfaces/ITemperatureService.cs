using PetMicroservice.Data.Entieties;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Interfaces
{

    public interface ITemperatureServices
    {

        public Temperature TemperatureById(int Id);
        public List<Temperature> GetAll();
        public void AddTemperature(Temperature temperature);
        public void DeleteTemperature(int Id);
        public Temperature UpdateTemperature(int Id, TemperatureVm temperature);
    }
}