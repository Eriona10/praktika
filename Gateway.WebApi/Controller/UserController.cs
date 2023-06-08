using Gateway.WebApi.Data.Entieties;
using Gateway.WebApi.Helpers;
using Gateway.WebApi.Repository.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using NuGet.ContentModel;
using NuGet.Protocol.Plugins;
using System.Data;
using User.Microservice.Data.Migrations;
using User.Microservice.Models;


namespace Gateway.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly PetTrackerContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        private readonly IUserRepository _userRepository;

        public List<AuthenticationScheme> ExternalLogins { get; private set; }

        public UserController(PetTrackerContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUserRepository userRepository)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Register model)
        {
            var result = await _userRepository.SignUpAsync(model);
            if (result.Succeeded)
            {
                return Ok(); // Registration successful
            }
            else
            {
                // Handle error in user creation
                return BadRequest(result.Errors);
            }
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (result.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    return Unauthorized();
                }
            }

            return BadRequest(ModelState);
        }
        [HttpGet]
        public async Task<ActionResult<List<AspNetUsers>>> Get()
        {
            return Ok(await _context.AspNetUsers.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AspNetUsers>> Get(int id)
        {
            var user = await _context.AspNetUsers.FindAsync(id);
            if (user == null)
                return BadRequest("Hero not found.");
            return Ok(user);
        }
    }
}