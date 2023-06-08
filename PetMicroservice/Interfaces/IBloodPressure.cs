using PetMicroservice.Data.Entieties;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Interfaces
{

    public interface IBloodPressureServices
    {

        public BloodPressure BloodPressureById(int Id);
        public List<BloodPressure> GetAll();
        public void AddBloodPressure(BloodPressure bloodPressure);
        public void DeleteBloodPressure(int Id);
        public BloodPressure UpdateBloodPressure(int Id, BloodPressureVm bloodPressure);
    }
}