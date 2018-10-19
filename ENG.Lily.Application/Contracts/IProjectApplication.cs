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
    }
}
