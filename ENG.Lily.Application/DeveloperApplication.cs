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
    public class DeveloperApplication : IDeveloperApplication
    {
        private readonly IMapper mapper;
        private readonly IDeveloperService developerService;

        public DeveloperApplication(IMapper mapper, IDeveloperService developerService)
        {
            this.mapper = mapper;
            this.developerService = developerService;
        }

        public void Save(DeveloperModel model)
        {
            var domainDeveloper = mapper.Map<Developer>(model);
            this.developerService.Save(domainDeveloper);
        }
    }
}
