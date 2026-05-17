using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.Endpoints
{
    public class BitcoinDeEndpoints
    {
        public static string GetTicker(string symbol)
        {
            return $"/v4/{symbol}/rates";
        }

        public static string GetOrderBook(string symbol)
        {
            return $"/v4/{symbol}/orderbook";
        }
    }
}
