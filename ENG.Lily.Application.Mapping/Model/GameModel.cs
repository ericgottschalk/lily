using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class GameModel
    {
        public string Name { get; set; }

        public string CoverUrl { get; set; }

        public List<GameGenreModel> Genres { get; set; }

        public PublisherModel Publisher { get; set; }
    }
}
