using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Sunflower.Domain.Entities
{
    public class Project : Base
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Media> Media { get; set; }

        public string WhyInvest { get; set; }

        public Developer Developer { get; set; }

        public GameGenre Genre { get; set; }
    }
}
