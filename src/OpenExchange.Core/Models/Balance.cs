using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    public class Balance
    {
        public string Asset { get; set; } = string.Empty;

        public decimal Available { get; set; }

        public decimal Locked { get; set; }
    }
}
