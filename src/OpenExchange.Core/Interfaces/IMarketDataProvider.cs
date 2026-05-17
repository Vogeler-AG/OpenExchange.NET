using System;
using System.Collections.Generic;
using System.Text;
using OpenExchange.Core.Models;

namespace OpenExchange.Core.Interfaces
{
    /// <summary>
    /// Provides market data retrieval methods (tickers, order book and trades).
    /// Implementations should return current market data for the given symbol.
    /// </summary>
    public interface IMarketDataProvider
    {
        /// <summary>
        /// Get the current ticker for the specified trading symbol.
        /// </summary>
        Task<Ticker> GetTickerAsync(string symbol, CancellationToken cancellationToken= default);

        /// <summary>
        /// Get the current order book for the specified trading symbol.
        /// </summary>
        Task<OrderBook> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get recent trades for the specified trading symbol.
        /// </summary>
        Task<IReadOnlyCollection<Trade>> GetTradesAsync(string symbol, CancellationToken cancellationToken = default);
    }
}
