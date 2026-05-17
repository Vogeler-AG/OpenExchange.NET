using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Interfaces
{
    /// <summary>
    /// Represents a unified exchange client that provides market data and trading
    /// functionality for a specific exchange implementation.
    /// </summary>
    public interface IExchangeClient : IMarketDataProvider, ITradingProvider
    {
        /// <summary>
        /// The unique name of the exchange (for example "bitcoin.de").
        /// </summary>
        string Name { get; }
    }
}
