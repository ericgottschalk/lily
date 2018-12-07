using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENG.Lily.Application.Mapping.Model
{
    public class ContribuitionModel
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
