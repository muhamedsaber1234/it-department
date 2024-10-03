using ITDepartment_DataAccess.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_BusinessLogic
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
    }
}
