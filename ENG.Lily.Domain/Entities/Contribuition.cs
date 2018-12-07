using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Lily.Domain.Entities
{
    public class Contribuition
    {
        public int IdUser { get; set; }

        public int IdProject { get; set; }

        public string CardNumber { get; set; }

        public string CardName { get; set; }

        public string Cvv { get; set; }

        public string CardExpiration { get; set; }

        public string TaxId { get; set; }

        public decimal Aumont { get; set; }
    }
}
