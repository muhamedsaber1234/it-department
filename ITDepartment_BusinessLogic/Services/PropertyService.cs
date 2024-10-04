using ITDepartment_DataAccess.models;
using ITDepartment_DataAccess.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_BusinessLogic.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IUnitOfWork unitOfWork;
        
        public PropertyService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Property> GetAllByCategoryId(int id)
        {
            return unitOfWork.Property.GetAll().Where(x => x.CategoryId == id );
        }
    }
}
