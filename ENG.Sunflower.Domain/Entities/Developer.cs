using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Lily.Domain.Entities
{
    public class Developer : User
    {
        public string Cpf { get; set; }

        public List<Project> Projects { get; set; }
    }
}
