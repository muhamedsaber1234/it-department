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
    public class DeviceRepository : BaseRepository<Device>,IDeviceRepository
    {
        private ITDBContext iTDBContext;
        public DeviceRepository(ITDBContext iTDBContext) : base(iTDBContext)
        {this.iTDBContext = iTDBContext;
        }
        public IEnumerable<Device> GetAllWithCategory()
        {
            return iTDBContext.Devices.Include(d => d.Category).ToList();
        }
        public Device GetbyNameAndDate(string name , DateTime dateTime)
        {
            var device =  iTDBContext.Devices.FirstOrDefault(x => x.AcquisitionDate == dateTime && x.Name == name);
            return device;
        }
            
    }
}
