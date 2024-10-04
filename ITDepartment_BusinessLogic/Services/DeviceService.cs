using ITDepartment_DataAccess.models;
using ITDepartment_DataAccess.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_BusinessLogic.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeviceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddDevice(Device device, List<PropertyValue> propertyValues)
        {
           await   _unitOfWork.Device.Add(device);
            foreach (var propertyValue in propertyValues)
            {
                propertyValue.DeviceId = device.Id;
              await  _unitOfWork.PropertyValue.Add(propertyValue);
            }
           await _unitOfWork.CompleteAsync(); 
        }

        public void UpdateDevice(Device device, List<PropertyValue> propertyValues)
        {
            _unitOfWork.Device.Update(device);
            foreach (var propertyValue in propertyValues)
            {
                _unitOfWork.PropertyValue.Update(propertyValue);
            }
            _unitOfWork.Complete();
        }

        public Device GetDeviceById(int id)
        {
            return _unitOfWork.Device.GetByID(id);
        }
        public IEnumerable<Device> GetAllDevices()
        {

            return _unitOfWork.Device.GetAll();
        }
        public IEnumerable<Device> GetAllWithCategory()
        {
            return _unitOfWork.DeviceRepository.GetAllWithCategory();
        }
    }
}
