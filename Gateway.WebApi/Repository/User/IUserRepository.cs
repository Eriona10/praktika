using Gateway.WebApi.Data.Entieties;
using Gateway.WebApi.Helpers;
using Microsoft.AspNetCore.Identity;


namespace Gateway.WebApi.Repository.User
{
    public interface IUserRepository
    {
        //Task SaveChanges();

        //Task<AspNetUsers> GetUserById(int id);

        //Task<IEnumerable<AspNetUsers>> GetAllUser();

        //Task CreateUser(AspNetUsers user);

        //Task DeleteUser(AspNetUsers user);

        Task<IdentityResult> SignUpAsync(Register model);
        Task<string> LoginAsync(Login model);

        Task SaveChanges();
    }
}
