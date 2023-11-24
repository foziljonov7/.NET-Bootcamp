using FoodAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Food>()
                .HasKey(f => f.Id);
            builder.Entity<Food>()
                .Property(f => f.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Entity<Food>()
                .Property(f => f.Price)
                .IsRequired();
            builder.Entity<Food>()
                .Property(f => f.Description)
                .HasMaxLength(250);
            builder.Entity<Food>()
                .HasOne(c => c.Category)
                .WithMany()
                .HasForeignKey(f => f.CategoryId)
                .IsRequired();
            builder.Entity<Category>()
                .Property(c => c.Name)
                .HasMaxLength(30)
                .IsRequired();
            builder.Entity<Category>()
                .HasData(
                    new { Id = 1, Name = "Fast food" },
                    new { Id = 2, Name = "Qo'yiq ovqat" },
                    new { Id = 3, Name = "Suyuq ovqat" }
                ) ;
            base.OnModelCreating(builder);
        }
    }
}
