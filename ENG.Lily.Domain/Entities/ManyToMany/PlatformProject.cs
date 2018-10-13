using ENG.Lily.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Lily.Domain.Entities.ManyToMany
{
    public class PlatformProject : Entity
    {
        public Project Project { get; set; }

        public Platform Platform { get; set; }
    }
}
