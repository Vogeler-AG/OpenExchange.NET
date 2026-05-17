using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Models
{
    /// <summary>
    /// Represents the balance of an asset, including available and locked amounts.
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// Gets or sets the name of the asset.
        /// </summary>
        public string Asset { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the available amount of the asset.
        /// </summary>
        public decimal Available { get; set; }

        /// <summary>
        /// Gets or sets the locked amount of the asset.
        /// </summary>
        public decimal Locked { get; set; }
    }
}
