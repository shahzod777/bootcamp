using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Services
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}