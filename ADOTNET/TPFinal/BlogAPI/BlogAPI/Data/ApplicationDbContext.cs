using Microsoft.EntityFrameworkCore;

using TPFinal.Class;
namespace TPFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
