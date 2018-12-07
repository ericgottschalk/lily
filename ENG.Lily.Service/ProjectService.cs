using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Entities.ManyToMany;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infrastructure.Extensions;
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
        private IFundRepository fundRepository;

        public ProjectService(IProjectRepository projectRepository, IPlatformRepository platformRepository, IGameGenreRepository gameGenreRepository, IPlatformProjectRepository platformProjectRepository, IFundRepository fundRepository)
        {
            this.projectRepository = projectRepository;
            this.platformRepository = platformRepository;
            this.gameGenreRepository = gameGenreRepository;
            this.platformProjectRepository = platformProjectRepository;
            this.fundRepository = fundRepository;
        }

        public Project Get(int id)
        {
            var project = this.projectRepository.Get(id, t => t.Feedbacks, t => t.Funds, t => t.Genre, t => t.Media, t => t.Platforms, t => t.User);

            project.User.Password = string.Empty;
            project.User.Email = string.Empty;
            project.ReachedBudget = this.GetReachedBudget(project.Id);

            return project;
        }

        public List<Project> GetNewestProjects()
        {
            var projects = this.projectRepository.FindWithPlatforms(t => t.Genre, t => t.Media, t => t.User).OrderByDescending(t => t.DateCreate)
                .Select(t => new Project
                {
                    DateCreate = t.DateCreate,
                    Description = t.Description,
                    Genre = t.Genre,
                    Id = t.Id,
                    User = new User
                    {
                        Username = t.User.Username,
                        Verified = t.User.Verified
                    },
                    Media = t.Media,
                    Name = t.Name,
                    Platforms = t.Platforms,
                    TargetReleaseYear = t.TargetReleaseYear,
                    WebSite = t.WebSite,
                    GenreId = t.GenreId,
                    UserId = t.UserId,
                    Hash = t.Hash,
                    Budget = t.Budget,
                    CoverUrl = t.CoverUrl
                    
                }).ToList();

            this.SetPlatformsRaw(projects);

            return projects;
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
                project.Hash = Guid.NewGuid().ToString().Replace("-", string.Empty);
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
            var projects = this.projectRepository.FindWithPlatforms(t => t.UserId == idUser, t => t.Genre, t => t.Media, t => t.User).OrderByDescending(t => t.DateCreate).ToList();

            this.SetPlatformsRaw(projects);

            return projects;
        }

        private void SetPlatformsRaw(Project project)
        {
            if (project.Platforms == null)
            {
                return;
            }

            foreach (var platform in project.Platforms)
            {
                platform.Project = null;
                platform.Platform.Projects = null;
            }

            project.PlatformsRaw = project.Platforms.Select(t => t.Platform).OrderBy(t => t.Name).ToList();
        }

        private void SetPlatformsRaw(List<Project> projects)
        {
            foreach (var project in projects)
            {
                SetPlatformsRaw(project);
            }
        }

        public List<Project> GetByUser(string username)
        {
            var projects = this.projectRepository.FindWithPlatforms(t => t.User.Username == username, t => t.Genre, t => t.Media, t => t.User).OrderByDescending(t => t.DateCreate).ToList();

            this.SetPlatformsRaw(projects);

            return projects;
        }

        public List<Project> GetTopRatedProjects()
        {
            throw new NotImplementedException();
        }

        public List<Project> GetTopRatedProjects(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Project GetByHash(string hash)
        {
            var project = this.projectRepository.GetWithPlatforms(t => t.Hash == hash, t => t.Genre, t => t.Media, t => t.User);

            this.SetPlatformsRaw(project);
            project.ReachedBudget = this.GetReachedBudget(project.Id);

            return project;
        }

        public Project GetByHash(int idUser, string hash)
        {
            var project = this.projectRepository.GetWithPlatforms(t => t.UserId == idUser && t.Hash == hash, t => t.Genre, t => t.Media, t => t.User);

            this.SetPlatformsRaw(project);
            project.ReachedBudget = this.GetReachedBudget(project.Id);

            return project;
        }

        public void SaveCoverImage(int id, string coverUrl)
        {
            var dbProject = this.projectRepository.Get(id);

            dbProject.CoverUrl = coverUrl;

            this.projectRepository.Update(dbProject);
        }

        public bool Contribue(Contribuition entity)
        {
            if (!entity.CardNumber.IsValidCard())
            {
                throw new Exception("Invalid card number.");
            }

            var fund = new Fund()
            {
                Aumont = entity.Aumont,
                CreditCardLastFourDigits = entity.CardNumber.Substring(entity.CardNumber.Length - 4),
                IsConfirmed = true,
                ProjectId = entity.IdProject,
                TaxId = entity.TaxId,
                TransactionId = Guid.NewGuid().ToString().Replace("-", string.Empty),
                UserId = entity.IdUser,             
                DateCreate = DateTime.Now
            };

            this.fundRepository.Add(fund);

            return true;
        }

        private decimal GetReachedBudget(int idProject)
        {
            return this.fundRepository.GetTotalByIdProject(idProject);
        }

        public decimal GetUserTotalContribuition(int idUser, int idProject)
        {
            return this.fundRepository.GetTotalByIdProjectIdUser(idProject, idUser);
        }
    }
}
