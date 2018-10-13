using ENG.Lily.Domain.Common;
using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class Game : Entity
    {
        public string Name { get; set; }

        public string CoverUrl { get; set; }

        public GameGenre Genre { get; set; }

        public Publisher Publisher { get; set; }
    }
}
