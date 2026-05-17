using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoinDeRate
    {
        public decimal rate_weighted { get; set; }
        public decimal rate_weighted_3h { get; set; }
        public decimal rate_weighted_12h { get; set; }
    }
}
