using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Sunflower.Domain.Entities
{
    public class Game : Base
    {
        public string Name { get; set; }

        public string CoverUrl { get; set; }

        public GameGenre Genre { get; set; }

        public Publisher Publisher { get; set; }
    }
}
