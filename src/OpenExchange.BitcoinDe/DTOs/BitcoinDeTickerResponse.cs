using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoinDeTickerResponse
    {
        public string? Bid { get; set; }

        public string? Ask { get; set; }

        public string? Last { get; set; }

        public string? Volume { get; set; }
    }
}
