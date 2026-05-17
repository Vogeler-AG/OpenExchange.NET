using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoinDeRate
    {
        /// <summary>
        /// Weighted rate value.
        /// </summary>
        public decimal rate_weighted { get; set; }

        /// <summary>
        /// Weighted rate for the last 3 hours.
        /// </summary>
        public decimal rate_weighted_3h { get; set; }

        /// <summary>
        /// Weighted rate for the last 12 hours.
        /// </summary>
        public decimal rate_weighted_12h { get; set; }
    }
}
