using System.Threading.Tasks;
using BTNETApi.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BTNETApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _projectService.GetAll();
            return Ok(users);
        }
    }
}