using OpenExchange.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Interfaces
{
    /// <summary>
    /// Defines trading operations such as placing and cancelling orders.
    /// </summary>
    public interface ITradingProvider
    {
        /// <summary>
        /// Place a new order on the exchange.
        /// </summary>
        Task<OrderResult> PlaceOrderBookAsync(OrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel an existing order identified by the given order id.
        /// </summary>
        Task CancelOrderBookAsync(string orderId, CancellationToken cancellationToken = default);

    }
}
