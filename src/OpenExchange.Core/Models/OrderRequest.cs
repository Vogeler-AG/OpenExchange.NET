using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    /// <summary>
    /// Represents a request to place an order in the trading system.
    /// </summary>
    public class OrderRequest
    {
        public string Symbol { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Amount { get; set; }

        public OrderSide Side { get; set; }

        public OrderType Type { get; set; }
    }
}
