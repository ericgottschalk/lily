using ENG.Lily.Domain.Entities;
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
    }
}
