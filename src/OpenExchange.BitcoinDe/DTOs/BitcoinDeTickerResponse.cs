using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.DTOs
{
    /// <summary>
    /// DTO representing the ticker response payload returned by the bitcoin.de API.
    /// </summary>
    public class BitcoinDeTickerResponse: BitcoindDeResponseBase
    {
        /// <summary>
        /// The trading pair identifier returned by the API.
        /// </summary>
        public string trading_pair { get; set; } = null!;

        /// <summary>
        /// Rate information contained in the response.
        /// </summary>
        public BitcoinDeRate rates { get; set; } = null!;
    }
}
