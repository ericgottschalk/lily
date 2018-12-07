using ENG.Lily.Domain.Common;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Domain.Repositories
{
    public interface IFundRepository : IRepository<Fund>
    {
        decimal GetTotalByIdProject(int idProject);
    }
}
