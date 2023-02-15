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
    internal class BlogRepository : IBlogDal
    {
        Context bgl = new Context();
        public void AddBlog(Blog blog)
        {
            bgl.Add(blog);
            bgl.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            bgl.Remove(blog);
            bgl.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return bgl.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            return bgl.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            bgl.Update(blog);
            bgl.SaveChanges();
        }
    }
}
