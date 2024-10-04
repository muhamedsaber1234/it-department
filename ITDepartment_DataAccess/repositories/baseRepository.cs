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
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private  ITDBContext iTDBContext;
        private DbSet<T> dbset;
        public BaseRepository(ITDBContext iTDBContext)
        {
            this.iTDBContext = iTDBContext;
            this.dbset = iTDBContext.Set<T>();
        }

        public async Task Add(T t)
        {
            dbset.Add(t);
        }

        public void Delete(T t) 
        {
            dbset.Remove(t);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetByID(int id)
        {
            return dbset.Find(id);
        }

        public void Update(T t)
        {
            dbset.Update(t);
        }
        

    }
}
