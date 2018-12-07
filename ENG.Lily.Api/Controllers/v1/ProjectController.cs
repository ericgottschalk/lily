using ENG.Lily.Api.Filters;
using ENG.Lily.Api.Models;
using ENG.Lily.Application.Contracts;
using ENG.Lily.Application.Mapping.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace ENG.Lily.Api.Controllers.v1
{
    [Produces("application/json")]
    [Route("api/project")]
    public class ProjectController : Controller
    {
        private readonly IProjectApplication projectApplication;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProjectController(IProjectApplication projectApplication, IHostingEnvironment hostingEnvironment)
        {
            this.projectApplication = projectApplication;
            this.hostingEnvironment = hostingEnvironment;
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
        public IActionResult GetTopRated()
        {
            var projects = this.projectApplication.GetTopRatedProjects();

            return Ok(projects);
        }

        [HttpGet("top-rated/{page:int}/{pagesize:int}")]
        [AllowAnonymous]
        public IActionResult GetTopRated(int page, int pageSize)
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpGet("most-popular")]
        [AllowAnonymous]
        public IActionResult GetMostPopular()
        {
            var projects = this.projectApplication.GetMostPopular();

            return Ok(projects);
        }

        [HttpGet("most-popular/{page:int}/{pagesize:int}")]
        [AllowAnonymous]
        public IActionResult GetMostPopular(int page, int pageSize)
        {
            var projects = this.projectApplication.GetNewestProjects();

            return Ok(projects);
        }

        [HttpPost("save")]
        [Authentication]
        public IActionResult Save([FromBody] ProjectModel project)
        {
            this.projectApplication.Save(project);

            return Ok();
        }

        [HttpPost("upload-cover-image")]
        public IActionResult UploadCoverImage([FromForm] UploadCoverImageModel formData)
        {
            if (formData.File != null)
            {
                var coverImageUrl = this.SaveCoverImage(formData.IdProject, formData.File);
                this.projectApplication.SaveCoverImage(formData.IdProject, coverImageUrl);
            }

            return Ok();
        }

        [HttpGet("cover/{idProject:int}/{filename}")]
        public IActionResult CoverImage(int idProject, string filename)
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", $@"content\projects-covers\{idProject}", filename);

            return PhysicalFile(file, "image/png");
        }

        [HttpPost("contribue")]
        public IActionResult Contribue([FromBody] ContribuitionModel model)
        {
            try
            {
                var sucess = this.projectApplication.Contribue(model);

                return Ok(new { message = "Successful operation.", success = true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, success = false });
            }
        }

        [HttpGet("get-user-contribuition/{idUser:int}/{idProject:int}")]
        public IActionResult GetUserTotalContribuition(int idUser, int idProject)
        {
            var total = this.projectApplication.GetUserTotalContribuition(idUser, idProject);

            return Ok(total);
        }

        [HttpPost("feedback")]
        public IActionResult Feedback([FromBody] UserFeedbackModel model)
        {
            try
            {
                this.projectApplication.Feedback(model.IdUser, model.IdProject, model.Rank, model.Text);

                return Ok(new { message = "Successful operation.", success = true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, success = false });
            }
        }

        [HttpGet("get-user-feedback/{idUser:int}/{idProject:int}")]
        public IActionResult GetUserFeedback(int idUser, int idProject)
        {
            try
            {
                var feedback = this.projectApplication.GetUserFeedback(idUser, idProject);

                return Ok(new { message = "Successful operation.", success = true, feedback });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, success = false });
            }
        }

        [HttpGet("get-feedbacks/{idProject:int}")]
        public IActionResult GetFeedbacks(int idProject)
        {
             var feedbacks = this.projectApplication.GetFeedbacks(idProject);

             return Ok(feedbacks);
        }

        private string SaveCoverImage(int idProject, IFormFile coverImage)
        {
            if (coverImage.Length > 0)
            {
                var fileName = Convert.ToString(Guid.NewGuid()) + Path.GetExtension(coverImage.FileName);

                var path = Path.Combine(this.hostingEnvironment.WebRootPath, $@"content\projects-covers\{idProject}");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    var directoryInfo = new DirectoryInfo(path);

                    foreach (var file in directoryInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }

                using (var fileStream = System.IO.File.Create($@"{path}\{fileName}"))
                {
                    coverImage.CopyTo(fileStream);
                    fileStream.Flush();
                }

                return $"api/project/cover/{idProject}/{fileName}";
            }

            return null;
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

        [HttpGet("hash/{hash}")]
        [AllowAnonymous]
        public IActionResult GetByHash(string hash)
        {
            var projects = this.projectApplication.GetByHash(hash);

            return Ok(projects);
        }

        [HttpGet("for-edit/{idUser}/{hash}")]
        [AllowAnonymous]
        public IActionResult GetByHash(int idUser, string hash)
        {
            var projects = this.projectApplication.GetByHash(idUser, hash);

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