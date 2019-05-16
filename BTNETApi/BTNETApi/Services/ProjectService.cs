using System.Collections.Generic;
using System.Threading.Tasks;
using BTNETApi.Core;
using BTNETApi.Core.Entities;
using BTNETApi.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace BTNETApi.Services
{
    public class ProjectService : IProjectService
    {
        private BTNETContext _dbContext;
        public ProjectService(BTNETContext db)
        {
            _dbContext = db;
        }
        public async Task<List<Project>> GetAll()
        {
            var projects = await _dbContext.Projects.ToListAsync();
            return projects;
        }
    }
}
