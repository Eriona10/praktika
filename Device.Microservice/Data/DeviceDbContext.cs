using Device.Microservice.Models;
using Microsoft.EntityFrameworkCore;

namespace Device.Microservice.Data
{
    public class DeviceDbContext: DbContext
    {
        public DeviceDbContext(DbContextOptions<DeviceDbContext> options) : base(options)
    {

    }



        public DbSet<DeviceModel> Devices { get; set; }

    }
}
