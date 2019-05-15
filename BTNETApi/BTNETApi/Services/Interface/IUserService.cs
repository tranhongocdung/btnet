using System.Collections.Generic;
using System.Threading.Tasks;
using BTNETApi.Core.Entities;

namespace BTNETApi.Services.Interface
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<List<User>> GetAll();
    }
}
