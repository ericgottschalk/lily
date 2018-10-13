using ENG.Lily.Domain.Entities;
using ENG.Lily.Domain.Repositories;
using ENG.Lily.Service.Contracts;

namespace ENG.Lily.Service
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDeveloperRepository developerRepository;
        public DeveloperService(IDeveloperRepository developerRepository)
        {
            this.developerRepository = developerRepository;
        }

        public void Save(Developer developer)
        {
            if (developer.IsNew())
            {
                this.developerRepository.Add(developer);
                return;
            }

            this.developerRepository.Update(developer);
        }
    }
}
