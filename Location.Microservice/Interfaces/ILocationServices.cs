using Location.Microservice.Data.Entieties;
using Location.Microservice.ViewModels;

namespace Location.Microservice.Interfaces
{
    public interface ILocationServices
    {
        public Locations LocationById(int Id);
        public List<Locations> GetAll();
     
        public void AddLocation(Locations location);
        public void DeleteLocation(int Id);
        public Locations UpdateLocation(int Id, LocationVm location);
    }
}
