using Microsoft.EntityFrameworkCore;
using Pet.Microservice.Models;

namespace Pet.Microservice.Data
{
    public class PetDbContext : DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext> options) : base(options)
        {

        }
        public DbSet<PetModel> Pets { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PetModel>()
                .HasOne(p => p.User)
                .WithMany(u => u.)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetUserLogins>().HasNoKey(); // Add this line to configure AspNetUserLogins as keyless entity

            base.OnModelCreating(modelBuilder);
        }*/

    }
}
