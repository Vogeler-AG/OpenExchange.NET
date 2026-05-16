
namespace OpenExchange.Core.Models
{
    public class OrderBook
    {
        public string Symbol { get; set; } = string.Empty;

        public IReadOnlyCollection<OrderBookEntry> Bids { get; set; }
            = Array.Empty<OrderBookEntry>();

        public IReadOnlyCollection<OrderBookEntry> Asks { get; set; }
            = Array.Empty<OrderBookEntry>();

        public DateTimeOffset Timestamp { get; set; }
    }
}