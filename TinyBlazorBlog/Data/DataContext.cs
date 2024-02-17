using Microsoft.EntityFrameworkCore;
using TinyBlazorBlog.Models;

namespace TinyBlazorBlog.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }

    }
}