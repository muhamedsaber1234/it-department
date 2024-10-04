using ITDepartment_DataAccess.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_BusinessLogic
{
    public interface IDeviceService
    {
        public Task AddDevice(Device device, List<PropertyValue> propertyValues);
        public void UpdateDevice(Device device, List<PropertyValue> propertyValues);
        public Device GetDeviceById(int id);
        public IEnumerable<Device> GetAllDevices();
        public IEnumerable<Device> GetAllWithCategory();
    }
}
