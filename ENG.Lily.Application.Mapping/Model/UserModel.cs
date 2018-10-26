using System;
using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class UserModel : Model
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

        public List<ProjectModel> Projects { get; set; }

        public List<FeedbackModel> Feedbacks { get; set; }

        public string Token { get; set; }

        public bool Verified { get; set; }
    }
}
