using DataAccessLayer.Entities.Base;

namespace BusinessLogicLayer.Repositories.Abstract
{
    public interface IRepository<T> where T : EntityBase, new()
    {
        Task<bool> AddAsync(T entity);
        Task<List<T>> GetAllAsync(bool? all);
        Task<T> GetByGuidAsync(Guid id);
        bool Update(T entity);
        bool Delete(T entity);
        Task<bool> DeleteAsync(Guid id);

        Task<bool> SaveChangesAsync();
    }
}
