using DataAccessLayer.Context;
using DataAccessLayer.Entities;

namespace DataAccessLayer.SeedDatas
{
    public class Seeder
    {
        private readonly DataDBContext _context;

        public Seeder(DataDBContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (!_context.Set<Product>().Any())
            {
                var entity1 = new Product { Name = "Mutfak Tasarımı ", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("6382203E-E51F-4982-A551-38FC7CA492A6") };
                var entity2 = new Product { Name = "Yemek Odası Tasarımı", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("A0E8E78E-342C-43DB-8542-499118EE87C0") };
                var entity3 = new Product { Name = "Yemek Masası Tasarımı", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("0A41149E-8AD9-4F18-85C5-CBD43AFB8EF4") };
                var entity4 = new Product { Name = "Banyo Tasarımı", IsSuccess = true, CreatedTime = DateTime.Now, Id = Guid.Parse("EA437201-61F6-4BDE-AD28-D2BF5F0CED94") };

                _context.Set<Product>().AddRange(entity1, entity2);
                _context.SaveChanges();
            }
        }
    }
}
