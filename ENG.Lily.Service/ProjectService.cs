﻿using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Entities.ManyToMany;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ENG.Lily.Service
{
    public class ProjectService : IProjectService
    {
        private IProjectRepository projectRepository;
        private IPlatformRepository platformRepository;
        private IGameGenreRepository gameGenreRepository;
        private IPlatformProjectRepository platformProjectRepository;

        public ProjectService(IProjectRepository projectRepository, IPlatformRepository platformRepository, IGameGenreRepository gameGenreRepository, IPlatformProjectRepository platformProjectRepository)
        {
            this.projectRepository = projectRepository;
            this.platformRepository = platformRepository;
            this.gameGenreRepository = gameGenreRepository;
            this.platformProjectRepository = platformProjectRepository;
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
            return this.projectRepository.FindTopOrderedByDate(10);
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

                foreach (var platform in project.PlatformsRaw)
                {
                    var platformProject = new PlatformProject
                    {
                        PlatformId = platform.Id,
                        ProjectId = project.Id
                    };

                    this.platformProjectRepository.Add(platformProject);
                }
            }
        }

        public List<Platform> GetPlatforms()
        {
            return this.platformRepository.Find();
        }

        public List<Project> GetByUser(int idUser)
        {
            var projects = this.projectRepository.FindWithPlatforms(t => t.UserId == idUser, t => t.Genre, t => t.Media).OrderByDescending(t => t.DateCreate).ToList();

            foreach (var project in projects)
            {
                if (project.Platforms == null)
                {
                    continue;
                }
                foreach (var platform in project.Platforms)
                {
                    platform.Project = null;
                    platform.Platform.Projects = null;
                }

                project.PlatformsRaw = project.Platforms.Select(t => t.Platform).ToList();
            }

            return projects;
        }
    }
}
