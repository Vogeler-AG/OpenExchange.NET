using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    public class BitcoindDeResponseBase
    {
        /// <summary>
        /// Optional location header returned by the API.
        /// </summary>
        public Uri? LocationHeader { get; set; }

        /// <summary>
        /// List of error messages returned by the API, if any.
        /// </summary>
        public List<BitcoinDeErrorMessage> errors { get; set; } = null!;

        /// <summary>
        /// Remaining credits or rate limit information as returned by the API.
        /// </summary>
        public int credits { get; set; }

        /// <summary>
        /// Nonce value returned by the API.
        /// </summary>
        public long nonce { get; set; }
    }
}
