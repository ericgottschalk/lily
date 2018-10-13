using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ENG.Lily.Application.Contracts;
using ENG.Lily.Application.Mapping.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENG.Lily.Api.Controllers.v1
{
    [Produces("application/json")]
    [Route("api/developer")]
    public class DeveloperController : Controller
    {
        private readonly IUserApplication userApplication;

        public DeveloperController(IUserApplication userApplication)
        {
            this.userApplication = userApplication;
        }

        [HttpPost]
        public IActionResult Save([FromBody] UserModel model)
        {
            this.userApplication.Save(model);

            return Ok();
        }
    }
}