using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoinDeErrorMessage
    {
        public string message { get; set; } = null!;
        public int code { get; set; }
    }
}
