using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class ProjectModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<MediaModel> Media { get; set; }

        public string WhyInvest { get; set; }

        public DeveloperModel Developer { get; set; }

        public List<GameGenreModel> Genres { get; set; }

        public List<FeedbackModel> Feedbacks { get; set; }

        public List<PlatformModel> Platforms { get; set; }
    }
}
