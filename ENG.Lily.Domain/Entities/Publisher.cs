﻿using System.Collections.Generic;

namespace ENG.Lily.Domain.Entities
{
    public class Publisher : User
    {
        public string CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public List<Game> Games { get; set; }
    }
}
