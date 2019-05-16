using System.Collections.Generic;
using System.Threading.Tasks;
using BTNETApi.Core.Entities;

namespace BTNETApi.Services.Interface
{
    public interface IProjectService
    {
        Task<List<Project>> GetAll();
    }
}
