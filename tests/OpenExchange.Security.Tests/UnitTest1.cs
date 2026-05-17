using OpenExchange.BitcoinDe.Clients;
using OpenExchange.Core.Interfaces;
using OpenExchange.Security.Credentials;
using System.Net;

namespace OpenExchange.BitcoinDe.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetTickerAsync_Returns_NormalizedTicker()
        {
            string json = """
    {
    "trading_pair": "btceur",
        "rates": {"rate_weighted":"100.23",
        "rate_weighted_3h":"101.23",
        "rate_weighted_12h":"102.23"}
    }
    """;

            var httpClient = new HttpClient(
                new FakeHttpMessageHandler(json))
            {
                BaseAddress = new Uri("https://api.bitcoin.de")
            };

            ICredentialProvider credentials =
                new StaticCredentialProvider(new ApiCredentials("test-key", "test-secret"));

            IExchangeClient client = new BitcoinDeClient(credentials, httpClient);

            var ticker = await client.GetTickerAsync("btceur");

            Assert.Equal("btceur", ticker.Symbol);
            Assert.Equal(100.23m, ticker.Last);
            Assert.Null(ticker.Bid);
            Assert.Null(ticker.Ask);
            Assert.Null(ticker.Volume);
        }
    }
}
