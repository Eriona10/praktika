

using Microsoft.EntityFrameworkCore;
using Pet.Data.Entieties;
using Pet.Interfaces;
using Pet.ViewModels;

namespace Pet.Services
{
    public class LocationService : ILocationService
    {
        private readonly PawTrackerContext _context;

        public LocationService(PawTrackerContext context)
        {
            _context = context;
        }

        public void AddLocation(Location locacion)
        {
            var _locacion = new Location()
            {

                Lat = locacion.Lat,
                Long = locacion.Long,
                DateMeasured = locacion.DateMeasured,
                PetId= locacion.PetId
            };

            _context.Location.Add(_locacion);
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

        public List<Location> GetAll()
        {
                return _context.Location.ToList();
            
        }

        public Location LocationById(int Id)
        {
            return _context.Location.Find(Id);
        }

        public Location UpdateLocation(int Id, LocationVM pet)
        {
            var existingLocation = _context.Location.Find(Id);
            if (existingLocation != null)
            {
                existingLocation.Lat = pet.Lat;
                existingLocation.Long = pet.Long;
                existingLocation.DateMeasured = pet.DateMeasured;
                existingLocation.PetId =pet.PetId;
                

                _context.SaveChanges();
            }

            return existingLocation;
        }
    }
}
