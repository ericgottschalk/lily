using ENG.Sunflower.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Sunflower.Domain.Entities
{
    public class Feedback : Base
    {
        public User User { get; set; }

        public Project Project { get; set; }

        public feedback Level { get; set; }
    }
}
