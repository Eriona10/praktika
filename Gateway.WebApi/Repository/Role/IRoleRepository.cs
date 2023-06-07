using Gateway.WebApi.Data.Entieties;
using Gateway.WebApi.ViewModels;

namespace Gateway.WebApi.Repository.Role
{
    public interface IRoleRepository
    {
        public AspNetRoles RoleById(string Id);
        public List<AspNetRoles> GetAll();

        public void AddRole(AspNetRoles roles);
        public void DeleteRole(string Id);
        public AspNetRoles UpdateRole(string Id, RoleVm roles);
    }
}
