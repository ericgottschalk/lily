using ENG.Lily.Domain.Common;
using ENG.Lily.Domain.Entities.ManyToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ENG.Lily.Domain.Entities
{
    public class Project : Entity
    {
        public string Hash { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CoverUrl { get; set; }

        public decimal Budget { get; set; }

        public List<Media> Media { get; set; }

        public string WebSite { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int GenreId { get; set; }
        public GameGenre Genre { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public List<Fund> Funds { get; set; }

        public List<PlatformProject> Platforms { get; set; }

        public DateTime DateCreate { get; set; }

        public int TargetReleaseYear { get; set; }      

        [NotMapped]
        public List<Platform> PlatformsRaw { get; set; }

        [NotMapped]
        public decimal ReachedBudget { get; set; }
    }
}
