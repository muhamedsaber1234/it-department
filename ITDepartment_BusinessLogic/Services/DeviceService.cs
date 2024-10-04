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

        public void AddDevice(Device device, List<PropertyValue> propertyValues)
        {
            try
            {
                _unitOfWork.Device.Add(device);
                _unitOfWork.Complete(); 

                var device1 = _unitOfWork.DeviceRepository.GetbyNameAndDate(device.Name, device.AcquisitionDate);

                foreach (var propertyValue in propertyValues)
                {
                    propertyValue.DeviceId = device1.Id; 
                    _unitOfWork.PropertyValue.Add(propertyValue);
                }
                _unitOfWork.Complete(); 
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while adding the device. Please try again later.");
            }
        }

        public void UpdateDevice(Device device, List<PropertyValue> propertyValues)
        {
            try
            {
                _unitOfWork.Device.Update(device);

                foreach (var propertyValue in propertyValues)
                {
                    _unitOfWork.PropertyValue.Update(propertyValue);
                }
                _unitOfWork.Complete(); 
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the device. Please try again later.");
            }
        }

        public Device GetDeviceById(int id)
        {
            try
            {
                return _unitOfWork.Device.GetByID(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving the device. Please try again later.");
            }
        }

        public IEnumerable<Device> GetAllDevices()
        {
            try
            {
                return _unitOfWork.Device.GetAll();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving devices. Please try again later.");
            }
        }

        public IEnumerable<Device> GetAllWithCategory()
        {
            try
            {
                return _unitOfWork.DeviceRepository.GetAllWithCategory();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving devices with categories. Please try again later.");
            }
        }
    }
}
