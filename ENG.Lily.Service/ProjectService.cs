using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Service.Contracts;
using System.Collections.Generic;

namespace ENG.Lily.Service
{
    public class ProjectService : IProjectService
    {
        private IProjectRepository projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public Project Get(int id)
        {
            var project = this.projectRepository.Get(id, t => t.Feedbacks, t => t.Funds, t => t.Genre, t => t.Media, t => t.Platforms, t => t.User);

            project.User.Password = string.Empty;
            project.User.Cpf = string.Empty;
            project.User.Email = string.Empty;

            return project;
        }

        public List<Project> GetNewestProjects()
        {
            return projectRepository.FindTopOrderedByDate(10);
        }
    }
}
