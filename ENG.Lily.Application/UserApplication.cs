using AutoMapper;
using ENG.Lily.Application.Contracts;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;
using ENG.Lily.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Lily.Application
{
    public class UserApplication : IUserApplication
    {
        private readonly IMapper mapper;
        private readonly IUserService userService;

        public UserApplication(IMapper mapper, IUserService userService)
        {
            this.mapper = mapper;
            this.userService = userService;
        }

        public UserModel Get(int id)
        {
            var domainUser = this.userService.Get(id);

            return this.mapper.Map<UserModel>(domainUser);
        }

        public UserModel Login(LoginModel model)
        {
            var domainUser = this.userService.Login(model.Username, model.Password);

            return this.mapper.Map<UserModel>(domainUser);
        }

        public void Save(UserModel model)
        {
            var domainDeveloper = mapper.Map<User>(model);
            this.userService.Save(domainDeveloper);
        }
    }
}
