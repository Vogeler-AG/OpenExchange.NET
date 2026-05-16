using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class Trade
    {
        public string Id { get; set; } = string.Empty;

        public string Symbol { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Amount { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
