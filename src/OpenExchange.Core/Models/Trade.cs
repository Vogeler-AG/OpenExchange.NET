using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class Trade
    {
        /// <summary>
        /// Unique identifier of the trade.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Trading symbol the trade belongs to.
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Trade price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Trade amount/quantity.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The timestamp when the trade occurred.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }
    }
}
