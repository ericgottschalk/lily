using ENG.Lily.Domain.Common;
using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class Project : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Media> Media { get; set; }

        public string WhyInvest { get; set; }

        public Developer Developer { get; set; }

        public List<GameGenre> Genres { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public List<Platform> Platforms { get; set; }
    }
}
