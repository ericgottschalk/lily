﻿using ENG.Lily.Domain.Common;
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

        public DateTime DateCreate { get; set; }
    }
}
