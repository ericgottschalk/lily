using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENG.Lily.Api.Models
{
    public class UserFeedbackModel
    {
        public int IdProject { get; set; }

        public int IdUser { get; set; }

        public int Rank { get; set; }

        public string Text { get; set; }
    }
}
