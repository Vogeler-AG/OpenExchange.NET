using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    /// <summary>
    /// The type of an order: Market or Limit.
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// Market order executes at the current market price.
        /// </summary>
        Market,

        /// <summary>
        /// Limit order specifies a price to buy or sell.
        /// </summary>
        Limit
    }
}
