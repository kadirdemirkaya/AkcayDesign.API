using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class DataDBContext : DbContext
    {
        public DataDBContext()
        {
        }

        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options)
        {
        }

        public DbSet<Register> Registers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product { Name = "Mutfak Tasarımı ", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("6382203E-E51F-4982-A551-38FC7CA492A6") },
                    new Product { Name = "Yemek Odası Tasarımı", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("A0E8E78E-342C-43DB-8542-499118EE87C0") },
                    new Product { Name = "Yemek Masası Tasarımı", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("0A41149E-8AD9-4F18-85C5-CBD43AFB8EF4") },
                    new Product { Name = "Banyo Tasarımı", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("EA437201-61F6-4BDE-AD28-D2BF5F0CED94") }
                );
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KCT444U\\SQLEXPRESS;Database=DataDBContext;Trusted_Connection=True;");
        }

    }
}
