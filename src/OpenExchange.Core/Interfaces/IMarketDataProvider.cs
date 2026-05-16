using System;
using System.Collections.Generic;
using System.Text;
using OpenExchange.Core.Models;

namespace OpenExchange.Core.Interfaces
{
    public interface IMarketDataProvider
    {
        Task<Ticker> GetTickerAsync(string symbol, CancellationToken cancellationToken= default);
        Task<OrderBook> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default);
        Task<IReadOnlyCollection<Trade>> GetTradesAsync(string symbol, CancellationToken cancellationToken = default);
    }
}
