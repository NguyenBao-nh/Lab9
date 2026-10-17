using Lab9.Models;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
namespace Lab9.Areas.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Ràng buộc không trùng tên (Unique) theo yêu cầu đề bài
        modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();
        modelBuilder.Entity<Banner>().HasIndex(b => b.Name).IsUnique();
        modelBuilder.Entity<Blog>().HasIndex(b => b.Name).IsUnique();
    }
}
