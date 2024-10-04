using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITDepartment_DataAccess.models;
namespace ITDepartment_BusinessLogic
{
    public interface IPropertyService
{
        public IEnumerable<Property> GetAllByCategoryId(int id);
}
}
