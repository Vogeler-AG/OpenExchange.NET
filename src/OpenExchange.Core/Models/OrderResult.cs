using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class OrderResult
    {
        /// <summary>
        /// Identifier of the created order as returned by the exchange.
        /// </summary>
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the operation was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Optional error message when the operation failed.
        /// </summary>
        public string? ErrorMessage { get; set; }
    }
}
