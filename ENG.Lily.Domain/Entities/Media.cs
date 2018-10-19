using ENG.Lily.Domain.Common;

namespace ENG.Lily.Domain.Entities
{
    public class Media : Entity
    {
        public string Url { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
