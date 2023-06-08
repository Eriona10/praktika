using Device.Microservice.Data;
using Device.Microservice.Interfaces;
using Device.Microservice.Models;
using Device.Microservice.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<DeviceModel>> GetDevices()
        {
            return await _context.Devices.ToListAsync();
        }
    }
//using Device.Microservice.Interfaces;
//using Device.Microservice.ViewModels;
//using Device.Microservice.Models;
//using static Device.Microservice.Services.DeviceService;
//using Ocelot.Values;

//namespace Device.Microservice.Services
//    {
//        public class DeviceService : IDeviceService
//        {
//            private readonly PetTrackerContext _context;

//            public DeviceService(PetTrackerContext context)
//            {
//                _context = context;
//            }

//            public void AddDevice(DeviceVM device)
//            {
//                var _device = new DeviceModel()
//                {
//                    name = device.name,
//                    //status = device.status,
//                    disabled = device.disabled,
//                    lastUpdate = device.lastUpdate,
//                    //phone = device.phone,
//                    model = device.model,
//                    //contact = device.contact,
//                    //category = device.category,
//                };

//                _context.Devices.Add(_device);
//                _context.SaveChanges();
//            }

//            public void DeleteDevice(int Id)
//            {
//                var device = _context.Devices.Find(Id);
//                if (device != null)
//                {
//                    _context.Devices.Remove(device);
//                    _context.SaveChanges();
//                }
//            }

//            public List<DeviceModel> GetAll()
//            {
//                return _context.Devices.ToList();
//            }

//            public DeviceModel DeviceById(int Id)
//            {
//                return _context.Devices.Find(Id);
//            }

//            public DeviceModel Updatedevice(int Id, DeviceVM device)
//            {
//                var existingDevice = _context.Devices.Find(Id);
//                if (existingDevice != null)
//                {
//                    existingDevice.name = device.name;
//                    //existingDevice.status = device.status;
//                    existingDevice.disabled = device.disabled;
//                    existingDevice.lastUpdate = device.lastUpdate;
//                    //existingDevice.phone = device.phone;
//                    existingDevice.model = device.model;
//                    //existingDevice.contact = device.contact;
//                    //existingDevice.category = device.category;

//                    _context.SaveChanges();
//                }

//                return existingDevice;
//            }

//            public DeviceModel UpdateDevice(int Id, DeviceVM device)
//            {
//                throw new NotImplementedException();
//            }
//        }
//    }

}
