
using Pet.Data.Entieties;
using Pet.ViewModels;

namespace Pet.Interfaces
{
    public interface ILocationService
    {

        public Location LocationById(int Id);
        public List<Location> GetAll();
        public void AddLocation(Location location);
        public void DeleteLocation(int Id);
        public Location UpdateLocation(int Id, LocationVM location);
    }
}
