using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class Developer : User
    {
        public string Cpf { get; set; }

        public List<Project> Projects { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public List<Fund> SendedFunds { get; set; }
    }
}
