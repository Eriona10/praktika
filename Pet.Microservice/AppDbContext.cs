using Microsoft.EntityFrameworkCore;
using Pet.Microservice.Models;


namespace Pet.Microservice
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<PetModel> Pets { get; set; }
    }
}
