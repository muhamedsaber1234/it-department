using ITDepartment_DataAccess.Context;
using ITDepartment_DataAccess.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_DataAccess.repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        
        public IDeviceRepository DeviceRepository { get; private set; }
        public IBaseRepository<Category> Category { get; private set; }
        public IBaseRepository<Device> Device { get; private set; }
        public IBaseRepository<Property> Property { get; private set; }
        public IBaseRepository<PropertyValue> PropertyValue { get; private set; }
        private readonly ITDBContext _dbContext;
        public UnitOfWork(IDeviceRepository deviceRepository,ITDBContext iTDBContext, IBaseRepository<Category> categories , IBaseRepository<Device> devices , IBaseRepository<Property> properties , IBaseRepository<PropertyValue> propertiesValues )
        {
            _dbContext = iTDBContext;
            this.Category= categories;
            this.Device= devices;
            this.Property= properties;
            this.PropertyValue= propertiesValues;
            this.DeviceRepository= deviceRepository;
        }
        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
        public async Task CompleteAsync()
        {
            await _dbContext.SaveChangesAsync(); // Save changes asynchronously
        }
        public void Dispose()
        { 
        _dbContext.Dispose();
        }
    }
}
