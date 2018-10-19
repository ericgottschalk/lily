using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Service.Contracts;
using System;
using System.Collections.Generic;

namespace ENG.Lily.Service
{
    public class ProjectService : IProjectService
    {
        private IProjectRepository projectRepository;
        private IPlatformRepository platformRepository;
        private IGameGenreRepository gameGenreRepository;

        public ProjectService(IProjectRepository projectRepository, IPlatformRepository platformRepository, IGameGenreRepository gameGenreRepository)
        {
            this.projectRepository = projectRepository;
            this.platformRepository = platformRepository;
            this.gameGenreRepository = gameGenreRepository;
        }

        public Project Get(int id)
        {
            var project = this.projectRepository.Get(id, t => t.Feedbacks, t => t.Funds, t => t.Genre, t => t.Media, t => t.Platforms, t => t.User);

            project.User.Password = string.Empty;
            project.User.Email = string.Empty;

            return project;
        }

        public List<Project> GetNewestProjects()
        {
            return projectRepository.FindTopOrderedByDate(10);
        }

        public List<GameGenre> GetGenres()
        {
            return this.gameGenreRepository.Find();
        }

        public void Save(Project project)
        {
            if (project.IsNew())
            {
                project.DateCreate = DateTime.Now;
                this.projectRepository.Add(project);
            }
        }

        public List<Platform> GetPlatforms()
        {
            return this.platformRepository.Find();
        }
    }
}
