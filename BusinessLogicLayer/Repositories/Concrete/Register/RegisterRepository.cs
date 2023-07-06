using BusinessLogicLayer.Repositories.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Repositories.Concrete
{
    public class RegisterRepository : Repository<Register>, IRegisterRepository
    {
        private readonly DataDBContext _context;
        public RegisterRepository(DataDBContext dataDBContext, DataDBContext context) : base(dataDBContext)
        {
            _context = context;
        }


        public async Task<bool> FindRegisterByEmail(string email)
        {
            Register register = await _context.Set<Register>().Where(r => r.Email == email).FirstOrDefaultAsync();
            if (register is not null)
                return true;
            return false;
        }
    }
}
