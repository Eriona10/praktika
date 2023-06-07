using Device.Microservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace Device.Microservice.Interfaces
{
    public interface IDeviceService
    {
        Task<IActionResult> AddDevice(DeviceRequest request, int petId);
        Task<IActionResult> UpdateDevice(DeviceRequest request, int petId);
        Task<IActionResult> DeleteDevice(int petId);
        Task<List<DeviceModel>> GetDevices();
    }
}
