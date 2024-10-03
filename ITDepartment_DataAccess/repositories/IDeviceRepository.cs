using ITDepartment_DataAccess.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_DataAccess.repositories
{
    public interface IDeviceRepository :IBaseRepository<Device>
    {
        public IEnumerable<Device> GetAllWithCategory();
    }
}
