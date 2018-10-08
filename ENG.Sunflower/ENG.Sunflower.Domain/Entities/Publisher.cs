using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Sunflower.Domain.Entities
{
    public class Publisher : User
    {
        public string CompanyName { get; set; }

        public bool IsVerified { get; set; }
    }
}
