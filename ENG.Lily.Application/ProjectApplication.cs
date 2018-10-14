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
    public class ProjectApplication : IProjectApplication
    {
        private readonly IMapper mapper;
        private readonly IProjectService projectService;

        public ProjectApplication(IMapper mapper, IProjectService projectService)
        {
            this.mapper = mapper;
            this.projectService = projectService;
        }

        public ProjectModel Get(int id)
        {
            var domainProject = this.projectService.Get(id);

            return mapper.Map<ProjectModel>(domainProject);
        }

        public List<ProjectModel> GetNewestProjects()
        {
            var domainProjects = this.projectService.GetNewestProjects();

            return mapper.Map<List<ProjectModel>>(domainProjects);
        }

        public void Save(ProjectModel model)
        {
            var domainProject = this.mapper.Map<Project>(model);         
            this.projectService.GetNewestProjects();
        }
    }
}
