using ENG.Lily.Domain.Common;
using ENG.Lily.Domain.Entities.ManyToMany;
using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class Platform : Entity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public List<PlatformProject> Projects { get; set; }
    }
}
