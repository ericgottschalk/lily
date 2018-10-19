using ENG.Lily.Domain.Common;
using ENG.Sunflower.Domain.Enum;
using System;

namespace ENG.Lily.Domain.Entities
{
    public class Feedback : Entity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public feedback Level { get; set; }

        public string Text { get; set; }

        public DateTime DateCreate { get; set; }
        
    }
}
