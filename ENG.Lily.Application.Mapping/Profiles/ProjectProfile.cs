using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            this.CreateMap<Project, ProjectModel>();
            this.CreateMap<ProjectModel, Project>();
        }
    }
}
