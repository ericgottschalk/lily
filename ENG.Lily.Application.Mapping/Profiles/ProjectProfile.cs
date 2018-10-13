using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class ProjectProfile : Profile
    {
        internal ProjectProfile()
        {
            this.CreateMap<Project, ProjectModel>();
            this.CreateMap<ProjectModel, Project>();
        }
    }
}
