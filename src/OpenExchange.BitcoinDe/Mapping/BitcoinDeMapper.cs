using OpenExchange.BitcoinDe.DTOs;
using OpenExchange.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenExchange.BitcoinDe.Mapping
{
    public class BitcoinDeMapper
    {
        public static Ticker MapTicker(BitcoinDeTickerResponse dto)
        {
            return new Ticker
            {
                Symbol = dto.trading_pair,
                Last = dto.rates.rate_weighted,

                Timestamp = DateTimeOffset.UtcNow
            };
        }
    }
}
