using OpenExchange.BitcoinDe.DTOs;
using OpenExchange.BitcoinDe.Endpoints;
using OpenExchange.BitcoinDe.Mapping;
using OpenExchange.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using OpenExchange.Core.Interfaces;

namespace OpenExchange.BitcoinDe.Clients
{
    public class BitcoinDeClient : IExchangeClient
    {
        private readonly HttpClient _httpClient;

        public string Name => "bitcoin.de";

        public BitcoinDeClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Ticker> GetTickerAsync(
            string symbol,
            CancellationToken cancellationToken = default)
        {
            var url = BitcoinDeEndpoints.GetTicker(symbol);

            var dto = await _httpClient.GetFromJsonAsync<BitcoinDeTickerResponse>(
                url,
                cancellationToken);

            if (dto == null)
            {
                throw new InvalidOperationException(
                    "Ticker response was null.");
            }

            return BitcoinDeMapper.MapTicker(dto);
        }

        public async Task<OrderBook> GetOrderBookAsync(
            string symbol,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyCollection<Trade>> GetTradesAsync(
            string symbol,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderResult> PlaceOrderBookAsync(
            OrderRequest request,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task CancelOrderBookAsync(
            string orderId,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
