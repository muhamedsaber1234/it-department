using ITDepartment_DataAccess.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_DataAccess.repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IDeviceRepository DeviceRepository { get; }
        IBaseRepository<Category> Category { get; }
        IBaseRepository<Device> Device { get; }
        IBaseRepository<Property> Property { get; }
        IBaseRepository<PropertyValue> PropertyValue { get; }
        int Complete();
        public  Task CompleteAsync();


    }
}