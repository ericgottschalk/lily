using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Infaestructure.Repository;
using ENG.Lily.Infaestructure.Repository.Repositories;

namespace ENG.Lily.Infrastructure.Repository.Repositories
{
    public class FeedbackRepository : Repository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(DatabaseContext context) 
            : base(context)
        {
        }
    }
}
