﻿using ENG.Lily.Domain.Entities;
using System.Collections.Generic;

namespace ENG.Lily.Service.Contracts
{
    public interface IProjectService
    {
        List<Project> GetNewestProjects();

        Project Get(int id);

        List<GameGenre> GetGenres();

        void Save(Project domainProject);
   
        List<Platform> GetPlatforms();

        List<Project> GetByUser(int idUser);

        List<Project> GetByUser(string username);

        List<Project> GetTopRatedProjects();

        List<Project> GetTopRatedProjects(int page, int pageSize);

        List<Project> GetMostPopular();

        Project GetByHash(string hash);

        Project GetByHash(int idUser, string hash);

        void SaveCoverImage(int id, string coverUrl);

        bool Contribue(Contribuition entity);

        decimal GetUserTotalContribuition(int idUser, int idProject);

        void Feedback(int idUser, int idProject, int rank, string text);

        Feedback GetUserFeedbackFeedback(int idUser, int idProject);

        List<Feedback> GetFeedbacks(int idProject);  
    }
}
