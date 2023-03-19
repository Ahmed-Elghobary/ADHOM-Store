using ADHOM_Store.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ADHOM_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable("Users");


            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Marketier" }, new IdentityRole { Name = "Admin" },
                new IdentityRole { Name = "Sales" });
        }
        public DbSet <Student> students { get; set; }
    }
}