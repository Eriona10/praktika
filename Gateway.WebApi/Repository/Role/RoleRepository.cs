using Gateway.WebApi.Data.Entieties;
using Gateway.WebApi.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Gateway.WebApi.Repository.Role
{
    public class RoleRepository : IRoleRepository
    { 
    private readonly PetTrackerContext _context;

    public RoleRepository(PetTrackerContext context)
    {
        _context = context;
    }

        public void AddRole(AspNetRoles roles)
        {
            var _roles = new AspNetRoles()
            {
                Id = roles.Id,
                Name = roles.Name,
                NormalizedName = roles.NormalizedName,
                ConcurrencyStamp = roles.ConcurrencyStamp,
               
            };

            _context.AspNetRoles.Add(_roles);
            _context.SaveChanges();
        }

        public void DeleteRole(string Id)
        {
            var roles = _context.AspNetRoles.Find(Id);
            if (roles != null)
            {
                _context.AspNetRoles.Remove(roles);
                _context.SaveChanges();
            }
        }

        public List<AspNetRoles> GetAll()
        {
            return _context.AspNetRoles.ToList();
        }

        public AspNetRoles RoleById(string Id)
        {
            return _context.AspNetRoles.Find(Id);
        }

        public AspNetRoles UpdateRole(string Id, RoleVm roles)
        {
            var existingRole = _context.AspNetRoles.Find(Id);
            if (existingRole != null)
            {
                existingRole.Name = roles.Name;
                existingRole.NormalizedName = roles.NormalizedName;
                existingRole.ConcurrencyStamp = roles.ConcurrencyStamp;
               


                _context.SaveChanges();
            }

            return existingRole;
        }

    }
}

