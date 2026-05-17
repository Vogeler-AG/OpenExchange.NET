using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class Ticker
    {
        /// <summary>
        /// Trading pair symbol (for example "BTC/EUR").
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Highest bid price.
        /// </summary>
        public decimal? Bid { get; set; }

        /// <summary>
        /// Lowest ask price.
        /// </summary>
        public decimal? Ask { get; set; }

        /// <summary>
        /// Last traded price.
        /// </summary>
        public decimal? Last { get; set; }
        
        /// <summary>
        /// Trading volume during the observed period.
        /// </summary>
        public decimal? Volume { get; set; }

        /// <summary>
        /// Timestamp of the ticker snapshot.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }
    }
}
