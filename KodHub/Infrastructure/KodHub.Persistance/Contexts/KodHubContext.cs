using KodHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KodHub.Persistance.Contexts
{
    public class KodHubContext : DbContext
    {
        public KodHubContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
