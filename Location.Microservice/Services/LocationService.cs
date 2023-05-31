using Location.Microservice.ViewModels;
using Microsoft.EntityFrameworkCore;
using Location.Microservice.Interfaces;
using Location.Microservice.Data.Entieties;

namespace Location.Microservice.Services
{
    public class LocationService : ILocationServices
    {
        private readonly PetTrackerContext _context;

        public LocationService(PetTrackerContext context)
        {
            _context = context;
        }

        public void AddLocation(Locations locacion)
        {
            var _locacion = new Locations()
            {

                Lat = locacion.Lat,
                Long = locacion.Long,
              
                PetId = locacion.PetId
            };

            _context.Locations.Add(_locacion);
            _context.SaveChanges();
        }

        public void DeleteLocation(int Id)
        {
            var pet = _context.Pet.Find(Id);
            if (pet != null)
            {
                _context.Pet.Remove(pet);
                _context.SaveChanges();
            }
        }

        public List<Locations> GetAll()
        {
            return _context.Locations.ToList();

        }

        public Locations LocationById(int Id)
        {
            return _context.Locations.Find(Id);
        }

        public Locations UpdateLocation(int Id, LocationVm pet)
        {
            var existingLocation = _context.Locations.Find(Id);
            if (existingLocation != null)
            {
                existingLocation.Lat = pet.Lat;
                existingLocation.Long = pet.Long;
               
                existingLocation.PetId = pet.PetId;


                _context.SaveChanges();
            }

            return existingLocation;
        }

         }
}
