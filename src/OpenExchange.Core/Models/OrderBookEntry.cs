using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    /// <summary>
    /// Represents a single entry in an order book (a price level).
    /// </summary>
    public class OrderBookEntry
    {
        /// <summary>
        /// The price for this order book entry.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The amount available at the specified price.
        /// </summary>
        public decimal Amount { get; set; }
    }
}
