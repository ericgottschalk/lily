using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Lily.Domain.Entities
{
    public class Game : Base
    {
        public string Name { get; set; }

        public string CoverUrl { get; set; }

        public List<GameGenre> Genres { get; set; }

        public Publisher Publisher { get; set; }
    }
}
