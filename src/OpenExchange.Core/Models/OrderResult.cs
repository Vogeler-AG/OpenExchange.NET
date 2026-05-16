using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class OrderResult
    {
        public string OrderId { get; set; } = string.Empty;

        public bool Success { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
