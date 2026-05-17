using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoindDeResponseBase
    {
        public Uri? LocationHeader { get; set; }
        public List<BitcoinDeErrorMessage> errors { get; set; } = null!;
        public int credits { get; set; }
        public long nonce { get; set; }
    }
}
