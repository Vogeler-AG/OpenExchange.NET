using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class Ticker
    {
        public string Symbol { get; set; } = string.Empty;

        public decimal Bid { get; set; }

        public decimal Ask { get; set; }

        public decimal Last { get; set; }

        public decimal Volume { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
