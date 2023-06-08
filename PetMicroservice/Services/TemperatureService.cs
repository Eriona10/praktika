using PetMicroservice.Data.Entieties;
using PetMicroservice.Interfaces;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Services
{
    public class TemperatureService : ITemperatureServices
    {
        private readonly PetTrackerContext _context;

        public TemperatureService(PetTrackerContext context)
        {
            _context = context;
        }

        public void AddTemperature(Temperature temperature)
        {
            var _temperature = new Temperature()
            {

                Pet = temperature.Pet,
                Temperature1 = temperature.Temperature1,
                DataMeasured = temperature.DataMeasured

            };

            _context.Temperature.Add(_temperature);
            _context.SaveChanges();
        }

        public void DeleteTemperature(int Id)
        {
            var temperature = _context.Temperature.Find(Id);
            if (temperature != null)
            {
                _context.Temperature.Remove(temperature);
                _context.SaveChanges();
            }
        }

        public List<Temperature> GetAll()
        {
            return _context.Temperature.ToList();

        }

        public Temperature TemperatureById(int Id)
        {
            return _context.Temperature.Find(Id);
        }

        public Temperature UpdateTemperature(int Id, TemperatureVm temperature)
        {
            var existingTemperature = _context.Temperature.Find(Id);
            if (existingTemperature != null)
            {
                existingTemperature.Pet = temperature.PetId;
                existingTemperature.Temperature1 = temperature.Temperature1;
                existingTemperature.DataMeasured = temperature.DateMeasured;



                _context.SaveChanges();
            }

            return existingTemperature;
        }

    }
}
