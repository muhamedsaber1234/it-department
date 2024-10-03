using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDepartment_DataAccess.repositories
{
    public interface IBaseRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetByID(int id);
        public void Update(T t);
        public void Delete(T t );
        public void Add(T t);
    }
}
