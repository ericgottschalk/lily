using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Sunflower.Domain.Entities
{
    public class Media : Base
    {
        public string Url { get; set; }

        public Project Project { get; set; }
    }
}
