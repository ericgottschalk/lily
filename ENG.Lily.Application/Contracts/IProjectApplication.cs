using ENG.Lily.Application.Mapping.Model;
using System.Collections.Generic;

namespace ENG.Lily.Application.Contracts
{
    public interface IProjectApplication
    {
        void Save(ProjectModel model);

        List<ProjectModel> GetNewestProjects();

        ProjectModel Get(int id);

        List<GameGenreModel> GetGenres();

        List<PlatformModel> GetPlatfoms();

        List<ProjectModel> GetByUser(int idUser);

        List<ProjectModel> GetByUser(string username);

        List<ProjectModel> GetTopRatedProjects();

        List<ProjectModel> GetTopRatedProjects(int page, int pageSize);

        void SaveCoverImage(int id, string coverUrl);

        ProjectModel GetByHash(string hash);

        ProjectModel GetByHash(int idUser, string hash);

        bool Contribue(ContribuitionModel model);

        decimal GetUserTotalContribuition(int idUser, int idProject);

        void Feedback(int idUser, int idProject, int rank, string text);

        FeedbackModel GetUserFeedback(int idUser, int idProject);
    }
}
