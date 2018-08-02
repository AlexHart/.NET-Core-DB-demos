using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DbCoreDemos.EFCSharpInMemory.BusinessLogic
{

    public class BlogService
    {
        private BloggingContext _context;
        private Random rnd = new Random();
        
        public BlogService(BloggingContext context)
        {
            _context = context;
        }

        public void Add(string url)
        {
            var blog = new Blog { Url = url, Id = rnd.Next() };
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }

        public IEnumerable<Blog> GetAll()
        {
            return _context.Blogs
                .OrderBy(b => b.Url)
                .ToList();
        }

        public Blog FindOne(string url)
        {
            return _context.Blogs.FirstOrDefault(x => x.Url == url);
        }

    }
}
