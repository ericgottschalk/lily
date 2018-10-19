﻿using ENG.Lily.Domain.Common;
using ENG.Lily.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENG.Lily.Domain.Entities
{
    public class Fund : Entity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public decimal Aumont { get; set; }

        public string CreditCardLastFourDigits { get; set; }

        public creditCardCompany CreditCardCompany { get; set; }

        public string TransactionId { get; set; }

        public bool IsConfirmed { get; set; }

        public DateTime DateCreate { get; set; }
    }
}
