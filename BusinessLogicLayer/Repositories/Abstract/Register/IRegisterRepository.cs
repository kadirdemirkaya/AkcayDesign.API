using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Repositories.Abstract
{
    public interface IRegisterRepository : IRepository<Register>
    {
        Task<bool> FindRegisterByEmail(string email);
    }
}
