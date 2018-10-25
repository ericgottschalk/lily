using ENG.Lily.Domain.Common;
using System;
using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class User : Entity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string WebSite { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string Phrase { get; set; }

        public DateTime DateCreate { get; set; }

        public List<Project> Projects { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public List<Fund> SendedFunds { get; set; }        
    }
}
