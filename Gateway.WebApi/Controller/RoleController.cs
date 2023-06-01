using Gateway.WebApi.Data.Entieties;
using Gateway.WebApi.Repository.Role;
using Gateway.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gateway.WebApi.Controller
{  
   [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
       private readonly PetTrackerContext _context;
      private readonly IRoleRepository _roleRepository;


            public RoleController(PetTrackerContext context, IRoleRepository roleRepository)
            {
                _context = context;
            _roleRepository = roleRepository;
            }

            [HttpPost("add-Role")]
            public IActionResult AddRole([FromBody] AspNetRoles roles)
            {
            _roleRepository.AddRole(roles);
                return Ok("Roli u regjistru");
            }
           
            [HttpGet]
            public IActionResult GetAllRoles()
            {
                var role = _roleRepository.GetAll();
                return Ok(role);    

            }


            [HttpGet("get-by-id /{id}")]
            public IActionResult GetPetById(string id)
            {
                var _role = _roleRepository.RoleById(id);
                return Ok(_role);
            }

            [HttpPut("update-by-id/{Id}")]
            public IActionResult UpdateRole(string Id, [FromBody] RoleVm roles)
            {
                var updatedRole = _roleRepository.UpdateRole(Id, roles);
                return Ok(updatedRole);
            }


            [HttpDelete("delete-Role/{Id}")]
            public IActionResult DeleteRole(string Id)
            {
            _roleRepository.DeleteRole(Id);
                return Ok("Roli eshte fshrire");
            }
        }
}
