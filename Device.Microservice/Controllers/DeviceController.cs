using Device.Microservice.Interfaces;
using Device.Microservice.Models;
using Device.Microservice.Services;
using Microsoft.AspNetCore.Mvc;

namespace Device.Microservice.Controllers
{
    [ApiController]
    [Route("api/devices")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            this.deviceService = deviceService;
        }

        [HttpPost]
        public async Task<IActionResult> AddDevice(DeviceRequest request, int petId)
        {
            var result = await deviceService.AddDevice(request, petId);
            return result;
        }

        [HttpPut("{petId}")]
        public async Task<IActionResult> UpdateDevice(DeviceRequest request, int petId)
        {
            var result = await deviceService.UpdateDevice(request, petId);
            return result;
        }

        [HttpDelete("{petId}")]
        public async Task<IActionResult> DeleteDevice(int petId)
        {
            var result = await deviceService.DeleteDevice(petId);
            return result;
        }


        // GET: api/devices
        [HttpGet]
        public async Task<ActionResult<List<DeviceModel>>> GetDevices()
        {
            var devices = await deviceService.GetDevices();
            return Ok(devices);
        }

    }
}