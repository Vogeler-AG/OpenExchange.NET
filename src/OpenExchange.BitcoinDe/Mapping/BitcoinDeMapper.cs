using OpenExchange.BitcoinDe.DTOs;
using OpenExchange.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.Mapping
{
    public class BitcoinDeMapper
    {
        public static Ticker MapTicker(
            BitcoinDeTickerResponse dto)
        {
            return new Ticker
            {
                Symbol = "BTC/EUR",

                Bid = decimal.Parse(dto.Bid ?? "0"),

                Ask = decimal.Parse(dto.Ask ?? "0"),

                Last = decimal.Parse(dto.Last ?? "0"),

                Volume = decimal.Parse(dto.Volume ?? "0"),

                Timestamp = DateTimeOffset.UtcNow
            };
        }
    }
}
