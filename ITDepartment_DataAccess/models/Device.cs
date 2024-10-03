using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_DataAccess.models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public string? Memo { get; set; }

        public Category? Category { get; set; }
        public ICollection<PropertyValue>? PropertyValues { get; set; }
    }
}
