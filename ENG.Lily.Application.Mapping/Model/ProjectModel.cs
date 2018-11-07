using System;
using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class ProjectModel : Model
    {
        public string Hash { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CoverUrl { get; set; }

        public List<MediaModel> Media { get; set; }

        public string WebSite { get; set; }

        public int UserId { get; set; }
        public UserModel User { get; set; }

        public int GenreId { get; set; }
        public GameGenreModel Genre { get; set; }

        public List<FeedbackModel> Feedbacks { get; set; }

        public List<PlatformModel> PlatformsRaw { get; set; }

        public List<PlatformProjectModel> Platforms { get; set; }

        public DateTime DateCreate { get; set; }

        public int TargetReleaseYear { get; set; }

        public decimal FundsAumont { get; set; }
    }
}
