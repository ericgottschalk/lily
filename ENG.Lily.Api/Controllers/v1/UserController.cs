using System;
using System.IO;
using ENG.Lily.Api.Filters;
using ENG.Lily.Api.Models;
using ENG.Lily.Application.Contracts;
using ENG.Lily.Application.Mapping.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENG.Lily.Api.Controllers.v1
{
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IUserApplication userApplication;

        public UserController(IUserApplication userApplication, IHostingEnvironment hostingEnvironment)
        {
            this.userApplication = userApplication;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public IActionResult Register([FromBody] UserModel model)
        {
            this.userApplication.Save(model);

            return Ok();
        }

        [HttpPut("update")]
        [Authentication]
        public IActionResult Update([FromBody] UserModel model, [FromBody] IFormFile picture)
        {
            if (picture != null)
            {
                model.ProfilePictureUrl = this.SaveProfilePicture(model.Id, picture);
            }

            this.userApplication.Save(model);

            return Ok();
        }

        [HttpPost("upload-profile-picture")]
        [Authentication]
        public IActionResult Upload([FromForm] UploadProfilePictureModel formData)
        {
            if (formData.File != null)
            {
                var profilePictureUrl = this.SaveProfilePicture(formData.Id, formData.File);
                this.userApplication.SaveProfilePictureUrl(formData.Id, profilePictureUrl);
            }     

            return Ok();
        }

        [HttpGet("profile-picture/{id:int}/{filename}")]
        public IActionResult ProfilePicture(int id, string filename)
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", $@"content\profiles\{id}", filename);

            return PhysicalFile(file, "image/png");
        }

        [HttpGet("get/{id:int}")]
        [AllowAnonymous]
        public IActionResult Get(int id)
        {
            var user = this.userApplication.Get(id);

            return Ok(user);
        }

        [HttpGet("get/{username}")]
        [AllowAnonymous]
        public IActionResult Get(string username)
        {
            var user = this.userApplication.Get(username);

            return Ok(user);
        }

        private string SaveProfilePicture(int id, IFormFile picture)
        {
            if (picture.Length > 0)
            {
                var fileName = Convert.ToString(Guid.NewGuid()) + Path.GetExtension(picture.FileName);

                var path = Path.Combine(this.hostingEnvironment.WebRootPath, $@"content\profiles\{id}");

                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (var fileStream = System.IO.File.Create($@"{path}\{fileName}"))
                {
                    picture.CopyTo(fileStream);
                    fileStream.Flush();
                }

                return $"api/user/profile-picture/{id}/{fileName}";
            }

            return null;
        }
    }
}