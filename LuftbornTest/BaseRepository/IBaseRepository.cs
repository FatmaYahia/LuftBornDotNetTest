using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepository
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Delete(T entity);
        int SaveChanges();
        void CreateEntity(T entity);
        void UpdateEntity(T entity);
    }
}
