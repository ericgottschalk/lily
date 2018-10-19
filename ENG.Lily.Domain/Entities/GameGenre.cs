using System.Collections.Generic;
using ENG.Lily.Domain.Common;

namespace ENG.Lily.Domain.Entities
{
    public class GameGenre : Entity
    {
        public string Name { get; set; }

        public string Code { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}
