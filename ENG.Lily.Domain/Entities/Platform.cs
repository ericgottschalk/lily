using ENG.Lily.Domain.Common;
using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class Platform : Entity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public List<Project> Projects { get; set; }
    }
}
