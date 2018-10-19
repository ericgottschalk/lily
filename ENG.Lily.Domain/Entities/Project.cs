using ENG.Lily.Domain.Common;
using ENG.Lily.Domain.Entities.ManyToMany;
using System;
using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class Project : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Media> Media { get; set; }

        public string WhyInvest { get; set; }

        public User User { get; set; }

        public GameGenre Genre { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public List<Fund> Funds { get; set; }

        public List<PlatformProject> Platforms { get; set; }

        public DateTime DateCreate { get; set; }

        public int TargetReleaseYear { get; set; }
    }
}
