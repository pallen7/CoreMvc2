using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlite("Filename=./SportsStore.db");
        }
        public DbSet<Product> Products { get; set; }
    }
}