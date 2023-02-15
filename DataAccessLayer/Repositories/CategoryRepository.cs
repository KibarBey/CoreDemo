using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context bgl = new Context();
        public void AddCategory(Category category)
        {
            bgl.Add(category);
            bgl.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            bgl.Remove(category);
            bgl.SaveChanges();
        }

        public Category GetById(int id)
        {
            return bgl.Categorys.Find(id); 
        }

        public List<Category> ListAllCategory()
        {
            return bgl.Categorys.ToList();
        }

        public void UpdateCategory(Category category)
        {
            bgl.Update(category);
            bgl.SaveChanges();
        }
    }
}
