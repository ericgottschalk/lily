using ENG.Lily.Domain.Common;
using ENG.Sunflower.Domain.Enum;

namespace ENG.Lily.Domain.Entities
{
    public class Feedback : Entity
    {
        public User User { get; set; }

        public Project Project { get; set; }

        public feedback Level { get; set; }

        public string Text { get; set; }
    }
}
