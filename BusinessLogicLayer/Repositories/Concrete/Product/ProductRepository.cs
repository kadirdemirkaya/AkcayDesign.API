using BusinessLogicLayer.Repositories.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DataDBContext dataDBContext) : base(dataDBContext)
        {
        }
    }
}
