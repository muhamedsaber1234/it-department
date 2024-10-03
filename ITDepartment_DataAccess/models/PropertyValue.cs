using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_DataAccess.models
{
    public class PropertyValue
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int PropertyId { get; set; }
        public string? Value { get; set; }

        public Device? Device { get; set; }
        public Property? Property{ get; set; }
    }
}

