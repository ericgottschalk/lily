using ENG.Lily.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Lily.Domain.Entities.ManyToMany
{
    public class PlatformProject : Entity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
