using ENG.Lily.Api.Filters;
using ENG.Lily.Application.Contracts;
using ENG.Lily.Application.Mapping.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ENG.Lily.Api.Controllers.v1
{
    [Produces("application/json")]
    [Route("api/project")]
    public class ProjectController : Controller
    {
        private readonly IProjectApplication projectApplication;

        public ProjectController(IProjectApplication projectApplication)
        {
            this.projectApplication = projectApplication;
        }

        [HttpGet("newest")]
        [AllowAnonymous]
        public IActionResult GetNewest()
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpGet("newest/{page:int}/{pagesize:int}")]
        [AllowAnonymous]
        public IActionResult GetNewest(int page, int pageSize)
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpGet("top-rated")]
        [AllowAnonymous]
        public IActionResult GetTopTated()
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpGet("top-rated/{page:int}/{pagesize:int}")]
        [AllowAnonymous]
        public IActionResult GetTopTated(int page, int pageSize)
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpGet("most-popular")]
        [AllowAnonymous]
        public IActionResult GetMostPopulart()
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpGet("most-popular/{page:int}/{pagesize:int}")]
        [AllowAnonymous]
        public IActionResult GetMostPopulart(int page, int pageSize)
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpPost("save")]
        [Authentication]
        public IActionResult Save([FromBody] ProjectModel model)
        {
            this.projectApplication.Save(model);

            return Ok();
        }

        [HttpGet("get/{id:int}")]
        [AllowAnonymous]
        public IActionResult Get(int id)
        {
            var project = this.projectApplication.Get(id);

            return Ok(project);
        }

        [HttpGet("user/{idUser:int}")]
        [AllowAnonymous]
        public IActionResult GetByUser(int idUser)
        {
            var projects = this.projectApplication.GetByUser(idUser);

            return Ok(projects);
        }

        [HttpGet("user/{username}")]
        [AllowAnonymous]
        public IActionResult GetByUser(string username)
        {
            var projects = this.projectApplication.GetByUser(username);

            return Ok(projects);
        }

        [HttpGet("genres")]
        [AllowAnonymous]
        public IActionResult GetGenres()
        {
            var genres = this.projectApplication.GetGenres();

            return Ok(genres);
        }

        [HttpGet("platforms")]
        [AllowAnonymous]
        public IActionResult GetPlatforms()
        {
            var platforms = this.projectApplication.GetPlatfoms();

            return Ok(platforms);
        }
    }
}