using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTNETApi.Core;
using BTNETApi.Core.Entities;
using BTNETApi.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace BTNETApi.Services
{
    public class UserService : IUserService
    {
        private BTNETContext _dbContext;
        public UserService(BTNETContext db)
        {
            _dbContext = db;
        }
        public async Task<User> Authenticate(string username, string password)
        {
            var user = await _dbContext.Users.Where(o => o.Username == username && o.Password == password).FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<User>> GetAll()
        {
            var users = await _dbContext.Users.ToListAsync();
            return users;
        }
    }
}
