using Azure.Core;
using Gateway.WebApi.Data.Entieties;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using System.Text.Encodings.Web;
using System.Text;
using User.Microservice.Models;
using User.Microservice.Areas.Identity.Pages.Account;
using static Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal.ExternalLoginModel;
using System.Data;
using Gateway.WebApi.Helpers;
namespace Gateway.WebApi.Repository.User
{
    public class UserRepository : IUserRepository
    {
        public PetTrackerContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;



        public UserRepository(PetTrackerContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;

        }
        public async Task<IdentityResult> SignUpAsync(Register model)
        {

            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email,
                RoleId = model.RoleId,
                IsRoleConfirmed = true,
                EmailConfirmed = true
            };
            var userCreate = await _userManager.CreateAsync(user, model.Password);

            List<string> roleNames = _context.AspNetRoles
               .Where(t => t.Id == "89da4f13-e025-44f0-8340-282354813d37")
               .Select(t => t.Name)
                 .ToList();

            if (userCreate.Succeeded)
            {
                string roleName = roleNames.FirstOrDefault(); // Get the first role name from the list
                if (roleName != null)
                {
                    var resultRole = await _userManager.AddToRoleAsync(user, roleName);
                    // Handle the result as needed
                }
            }
            return userCreate;
        }


        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }

        public async Task<string> LoginAsync(Login model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (!result.Succeeded)
            {

            }
            return null;
        }



        //public async Task CreateUser(AspNetUsers user)
        //{
        //    if (user == null)
        //    {
        //        throw new ArgumentNullException(nameof(user));
        //    }
        //    //insertimi ne databaze me EFCore

        //    await _context.AspNetUsers.AddAsync(user);
        //}

        //public Task DeleteUser(AspNetUsers user)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<AspNetUsers>> GetAllUser()
        //{
        //    var users = await _context.AspNetUsers.ToListAsync();

        //    return users;
        //}

        //public Task<AspNetUsers> GetUserById(int id)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
