using System;
using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class ProjectModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<MediaModel> Media { get; set; }

        public string WhyInvest { get; set; }

        public UserModel User { get; set; }

        public GameGenreModel Genre { get; set; }

        public List<FeedbackModel> Feedbacks { get; set; }

        public List<PlatformModel> Platforms { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime TargetReleaseDate { get; set; }

        public decimal Funds { get; set; }
    }
}
