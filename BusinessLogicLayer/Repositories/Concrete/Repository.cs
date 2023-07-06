using BusinessLogicLayer.Repositories.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : EntityBase, new()
    {
        private readonly DataDBContext _dataDBContext;

        public Repository(DataDBContext dataDBContext)
        {
            _dataDBContext = dataDBContext;
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _dataDBContext.AddAsync(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _dataDBContext.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var entity = await GetByGuidAsync(id);
                bool result = Delete(entity);
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<T>> GetAllAsync(bool? all)
        {
            if (all == true)
                return await _dataDBContext.Set<T>().ToListAsync();
            return null;
        }

        public async Task<T> GetByGuidAsync(Guid id)
        {
            try
            {
                var entity = await _dataDBContext.Set<T>().SingleOrDefaultAsync(db => db.Id == id);
                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                await _dataDBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _dataDBContext.Set<T>().Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
