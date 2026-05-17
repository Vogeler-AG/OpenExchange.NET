using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoinDeErrorMessage
    {
        /// <summary>
        /// Error message text.
        /// </summary>
        public string message { get; set; } = null!;

        /// <summary>
        /// Numeric error code returned by the API.
        /// </summary>
        public int code { get; set; }
    }
}
