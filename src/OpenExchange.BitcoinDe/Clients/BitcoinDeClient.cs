using OpenExchange.BitcoinDe.DTOs;
using OpenExchange.BitcoinDe.Endpoints;
using OpenExchange.BitcoinDe.Mapping;
using OpenExchange.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using OpenExchange.BitcoinDe.Authentication;
using OpenExchange.Core.Interfaces;
using OpenExchange.Security.Credentials;
using OpenExchange.Security.Http;

namespace OpenExchange.BitcoinDe.Clients
{
    /// <summary>
    /// A concrete exchange client implementation for the bitcoin.de API.
    /// Provides market data and trading operations for bitcoin.de.
    /// </summary>
    public class BitcoinDeClient : IExchangeClient
    {
        private readonly HttpClient _httpClient;
        private readonly ICredentialProvider _credentialProvider;

        /// <inheritdoc/>
        public string Name => "bitcoin.de";

        /// <summary>
        /// Create a new client using an externally configured <see cref="HttpClient"/>.
        /// </summary>
        public BitcoinDeClient(ICredentialProvider credentialProvider, HttpClient httpClient)
        {
            _credentialProvider = credentialProvider;
            _httpClient = httpClient;
        }

        /// <summary>
        /// Create a new client and configure a default <see cref="HttpClient"/>
        /// with the signing handler that signs requests using the provided
        /// credential provider.    
        /// </summary>
        public BitcoinDeClient(ICredentialProvider credentialProvider)
        {
            _credentialProvider = credentialProvider;
            var signer = new BitcoinDeRequestSigner(_credentialProvider);
            var signingHandler = new SigningHandler(signer)
            {
                InnerHandler = new HttpClientHandler()
            };
            _httpClient = new HttpClient(signingHandler);
            _httpClient.BaseAddress = new Uri("https://api.bitcoin.de");
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
