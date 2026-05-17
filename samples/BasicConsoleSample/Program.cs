using OpenExchange.BitcoinDe.Clients;
using OpenExchange.Core.Interfaces;
using OpenExchange.Core.Models;
using OpenExchange.Security.Credentials;

namespace BasicConsoleSample
{
    internal static class Program
    {
        static async Task Main(string[] args)
        {
            ICredentialProvider cred= new EnvironmentCredentialProvider("BitcoinDeApiKey","BitcoinDeApiSecret");
            IExchangeClient client = new BitcoinDeClient(cred);
            Ticker ticker=await client.GetTickerAsync("btceur");
            Console.WriteLine($"BTC/EUR Last Price: {ticker.Last}");

        }
    }
}
