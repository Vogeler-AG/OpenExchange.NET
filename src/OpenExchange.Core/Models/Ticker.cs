using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class Ticker
    {
        /// <summary>
        /// Markt / Trading Pair
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// max. Buy price
        /// </summary>
        public decimal? Bid { get; set; }

        /// <summary>
        /// lowest sell price
        /// </summary>
        public decimal? Ask { get; set; }

        /// <summary>
        /// last price
        /// </summary>
        public decimal? Last { get; set; }
        
        /// <summary>
        /// trading volume
        /// </summary>
        public decimal? Volume { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }
    }
}
