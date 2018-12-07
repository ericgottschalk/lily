using System;
using System.Linq;

namespace ENG.Lily.Infrastructure.Extensions
{
    public static partial class Extensions
    {
        public static bool IsValidCard(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            str = str.Replace("-", "").Trim();

            int checksum = 0;
            bool evenDigit = false;

            foreach (char digit in str.Reverse())
            {
                if (digit < '0' || digit > '9')
                {
                    return false;
                }

                int digitValue = (digit - '0') * (evenDigit ? 2 : 1);
                evenDigit = !evenDigit;

                while (digitValue > 0)
                {
                    checksum += digitValue % 10;
                    digitValue /= 10;
                }
            }

            return (checksum % 10) == 0;
        }
    }
}
