using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoinDeTickerResponse: BitcoindDeResponseBase
    {
        public string trading_pair { get; set; } = null!;
        public BitcoinDeRate rates { get; set; }
    }
}
