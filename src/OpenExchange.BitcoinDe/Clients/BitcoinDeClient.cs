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
    public class BitcoinDeClient : IExchangeClient
    {
        private readonly HttpClient _httpClient;
        private readonly ICredentialProvider _credentialProvider;
        public string Name => "bitcoin.de";

        public BitcoinDeClient(ICredentialProvider credentialProvider, HttpClient httpClient)
        {
            _credentialProvider = credentialProvider;
            _httpClient = httpClient;
        }

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
