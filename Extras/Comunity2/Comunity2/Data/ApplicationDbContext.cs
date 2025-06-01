using Comunity2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Comunity2.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Quis> Quis { get; set; }
        public DbSet<DoQuis> DoQuis { get; set; }
        public DbSet<Likies> Likies { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Quistion> Quistions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<IdentityRole>().HasData(
            // new IdentityRole
            // {
            //     Id = Guid.NewGuid().ToString(),
            //     Name = "Admin",
            //     NormalizedName = "admin",
            //     ConcurrencyStamp = Guid.NewGuid().ToString()
            // },
            // new IdentityRole
            // {
            //     Id = Guid.NewGuid().ToString(),
            //     Name = "User",
            //     NormalizedName = "user",
            //     ConcurrencyStamp = Guid.NewGuid().ToString()
            // }
            //    );

            base.OnModelCreating(builder);
        }
    }
}
