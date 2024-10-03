using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_DataAccess.models
{
    public class Category
    {
       
            public int Id { get; set; }
            public string Name { get; set; }

           
            public ICollection<Device>? Devices { get; set; }
            public ICollection<Property>? Properties { get; set; }

    }
}
