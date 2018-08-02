using DbCoreDemos.EFCSharpInMemory.BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DbCoreDemos.EFCSharpInMemory
{
    class Program
    {
        static void Main(string[] args)
        {

            var options = new DbContextOptionsBuilder<BloggingContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

            // Run the test against one instance of the context
            using (var context = new BloggingContext(options))
            {
                var service = new BlogService(context);

                service.Add("http://sample.com");
                service.Add("http://github.com");
                service.Add("http://microsoft.com");
            }

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new BloggingContext(options))
            {
                var service = new BlogService(context);
                var blogs = service.GetAll().ToList();

                Console.WriteLine($"Count:\t{blogs.Count}"); // Should be 3

                foreach (var blog in blogs)
                {
                    Console.WriteLine(blog);
                }

                Console.WriteLine("--------------------------------------------------------------------------------");
                var oneBlog = service.FindOne("http://github.com");
                if (oneBlog != null)
                {
                    Console.WriteLine("Found!");
                    Console.WriteLine(oneBlog);
                }
                else
                {
                    Console.WriteLine("Blog not found");
                }
            }

        }
    }
}
