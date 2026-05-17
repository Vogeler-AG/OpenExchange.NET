
namespace OpenExchange.Core.Models
{
    /// <summary>
    /// Represents the order book for a trading symbol including bid and ask price levels.
    /// </summary>
    public class OrderBook
    {
        /// <summary>
        /// The trading symbol for this order book (for example BTC/EUR).
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Bid side price levels (buyers).
        /// </summary>
        public IReadOnlyCollection<OrderBookEntry> Bids { get; set; }
            = Array.Empty<OrderBookEntry>();

        /// <summary>
        /// Ask side price levels (sellers).
        /// </summary>
        public IReadOnlyCollection<OrderBookEntry> Asks { get; set; }
            = Array.Empty<OrderBookEntry>();

        /// <summary>
        /// The timestamp when the order book snapshot was taken.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }
    }
}