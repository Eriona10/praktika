using Microsoft.EntityFrameworkCore;
using Pet.Microservice.Models;


namespace Pet.Microservice
{
    public class PetDbContext : DbContext
    {
        public PetDbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<PetModel> Pets { get; set; }
    }
}
