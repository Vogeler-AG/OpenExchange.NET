using OpenExchange.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.Core.Interfaces
{
    public interface ITradingProvider
    {
        Task<OrderResult> PlaceOrderBookAsync(OrderRequest request, CancellationToken cancellationToken = default);
        Task CancelOrderBookAsync(string orderId, CancellationToken cancellationToken = default);

    }
}
