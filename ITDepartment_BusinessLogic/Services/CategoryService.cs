using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITDepartment_DataAccess.Context;
using ITDepartment_DataAccess.models;
using ITDepartment_DataAccess.repositories;
namespace ITDepartment_BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork) { this._unitOfWork = unitOfWork; }

        public IEnumerable<Category> GetAll()
        {
            return _unitOfWork.Category.GetAll();
            
        }
        
    }
}
