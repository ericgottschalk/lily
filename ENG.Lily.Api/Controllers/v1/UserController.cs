﻿using ENG.Lily.Application.Contracts;
using ENG.Lily.Application.Mapping.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ENG.Lily.Api.Controllers.v1
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/developer")]
    public class UserController : Controller
    {
        private readonly IUserApplication userApplication;

        public UserController(IUserApplication userApplication)
        {
            this.userApplication = userApplication;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register([FromBody] UserModel model)
        {
            this.userApplication.Save(model);

            return Ok();
        }
    }
}