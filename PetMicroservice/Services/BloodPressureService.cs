using PetMicroservice.Data.Entieties;
using PetMicroservice.Interfaces;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Services
{
    public class BloodPressureService: IBloodPressureServices
    {
        private readonly PetTrackerContext _context;

        public BloodPressureService(PetTrackerContext context)
        {
            _context = context;
        }

        public void AddBloodPressure(BloodPressure bloodPressure)
        {
            var _bloodPressure = new BloodPressure()
            {

                PetId = bloodPressure.PetId,
                SystolicValue = bloodPressure.SystolicValue,
                DiastolicValue = bloodPressure.DiastolicValue,
                DateMeasured = bloodPressure.DateMeasured

            };

            _context.BloodPressure.Add(_bloodPressure);
            _context.SaveChanges();
        }

        public void DeleteBloodPressure(int Id)
        {
            var bloodPressure = _context.BloodPressure.Find(Id);
            if (bloodPressure != null)
            {
                _context.BloodPressure.Remove(bloodPressure);
                _context.SaveChanges();
            }
        }

        public List<BloodPressure> GetAll()
        {
            return _context.BloodPressure.ToList();

        }

        public BloodPressure BloodPressureById(int Id)
        {
            return _context.BloodPressure.Find(Id);
        }

        public BloodPressure UpdateBloodPressure(int Id, BloodPressureVm bloodPressure)
        {
            var existingBloodPressure = _context.BloodPressure.Find(Id);
            if (existingBloodPressure != null)
            {
                existingBloodPressure.PetId = bloodPressure.PetId;
                existingBloodPressure.SystolicValue = bloodPressure.SystolicValue;
                existingBloodPressure.DiastolicValue = bloodPressure.DiastolicValue;
                existingBloodPressure.DateMeasured = bloodPressure.DateMeasured;



                _context.SaveChanges();
            }

            return existingBloodPressure;
        }

    }
}
