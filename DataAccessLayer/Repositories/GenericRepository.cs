using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context bgl = new Context();
        public void Delete(T item)
        {
            bgl.Remove(item);
            bgl.SaveChanges();
        }

        public List<T> GetAll()
        {
            return bgl.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return bgl.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            bgl.Add(item);
            bgl.SaveChanges();
        }

        public void Update(T item)
        {
            bgl.Update(item);
            bgl.SaveChanges();
        }
    }
}
