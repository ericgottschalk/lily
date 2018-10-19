using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ENG.Lily.Application.Contracts;
using ENG.Lily.Application.Mapping.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENG.Lily.Api.Controllers.v1
{
    [Authorize]
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

        [HttpPost("save")]
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