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
            this.projectService.Save(domainProject);
        }

        public List<GameGenreModel> GetGenres()
        {
            var domainGenres = this.projectService.GetGenres();
            return this.mapper.Map<List<GameGenreModel>>(domainGenres);
        }

        public List<PlatformModel> GetPlatfoms()
        {
            var domainPlatforms = this.projectService.GetPlatforms();
            return this.mapper.Map<List<PlatformModel>>(domainPlatforms);
        }

        public List<ProjectModel> GetByUser(int idUser)
        {
            var domainProjects = this.projectService.GetByUser(idUser);

            return mapper.Map<List<ProjectModel>>(domainProjects);
        }

        public List<ProjectModel> GetByUser(string username)
        {
            var domainProjects = this.projectService.GetByUser(username);

            return mapper.Map<List<ProjectModel>>(domainProjects);
        }

        public List<ProjectModel> GetTopRatedProjects()
        {
            var domainProjects = this.projectService.GetTopRatedProjects();

            return mapper.Map<List<ProjectModel>>(domainProjects);
        }

        public List<ProjectModel> GetTopRatedProjects(int page, int pageSize)
        {
            var domainProjects = this.projectService.GetTopRatedProjects(page, pageSize);

            return mapper.Map<List<ProjectModel>>(domainProjects);
        }

        public void SaveCoverImage(int id, string coverUrl)
        {
            this.projectService.SaveCoverImage(id, coverUrl);
        }

        ProjectModel IProjectApplication.GetByHash(string hash)
        {
            var domainProject = this.projectService.GetByHash(hash);

            return mapper.Map<ProjectModel>(domainProject);
        }

        public ProjectModel GetByHash(int idUser, string hash)
        {
            var domainProject = this.projectService.GetByHash(idUser, hash);

            return mapper.Map<ProjectModel>(domainProject);
        }

        public bool Contribue(ContribuitionModel model)
        {
            var domainEntity = mapper.Map<Contribuition>(model);
            return this.projectService.Contribue(domainEntity);
        }

        public decimal GetUserTotalContribuition(int idUser, int idProject)
        {
            return this.projectService.GetUserTotalContribuition(idUser, idProject);
        }

        public void Feedback(int idUser, int idProject, int rank, string text)
        {
            this.projectService.Feedback(idUser, idProject, rank, text);
        }

        public FeedbackModel GetUserFeedback(int idUser, int idProject)
        {
            var domainFeedback = this.projectService.GetUserFeedbackFeedback(idUser, idProject);

            return mapper.Map<FeedbackModel>(domainFeedback);
        }
    }
}
