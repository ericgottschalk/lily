using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infaestructure.Repository.Repositories;
using System.Linq;

namespace ENG.Lily.Infrastructure.Repository.Repositories
{
    public class FundRepository : Repository<Fund>, IFundRepository
    {
        public FundRepository(DatabaseContext context) 
            : base(context)
        {
        }

        public decimal GetTotalByIdProject(int idProject)
        {
            return this.context.Funds.Where(t => t.ProjectId == idProject && t.IsConfirmed).Sum(t => t.Aumont);
        }
    }
}
