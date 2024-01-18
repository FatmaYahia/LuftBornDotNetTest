using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContext DB;
        public BaseRepository(DataContext DB)
        {
            this.DB = DB;
        }
        public void CreateEntity(T entity)
        {
             DB.Set<T>().Add(entity);
        }

       public void Delete(T entity)
        {
             DB.Set<T>().Remove(entity);
        }

         public List<T> GetAll()
        {
            return DB.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return DB.Set<T>().Find(id);
        }

       public int SaveChanges()
        {
            return DB.SaveChanges();
        }

       public  void UpdateEntity(T entity)
        {
            DB.Entry(entity).State = EntityState.Modified;
        }
    }
}
