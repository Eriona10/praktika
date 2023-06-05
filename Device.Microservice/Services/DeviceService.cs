using Device.Microservice.Data;
using Device.Microservice.Interfaces;
using Device.Microservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace Device.Microservice.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly DeviceDbContext _context;


        public DeviceService(DeviceDbContext context)
        {
            _context = context;
        }
      
 

        public async Task<IActionResult> AddDevice(DeviceRequest request, int petId)
        {
            // Implement your AddDevice logic here
            // Make use of deviceRepository and petRepository as needed

            return new OkResult();
        }

        public async Task<IActionResult> UpdateDevice(DeviceRequest request, int petId)
        {
            // Implement your UpdateDevice logic here
            // Make use of deviceRepository and petRepository as needed

            return new OkResult();
        }

        public async Task<IActionResult> DeleteDevice(int petId)
        {
            // Implement your DeleteDevice logic here
            // Make use of deviceRepository and petRepository as needed

            return new OkResult();
        }
    }
}