using oanda_dotnet.model.pricing;

namespace oanda_dotnet.model.instrument
{
    /// <summary>
    /// The price data (open, high, low, close) for the Candlestick representation.
    /// </summary>
    public class CandlestickData
    {
        /// <summary> 
        /// The first (open) price in the time-range represented by the candlestick. 
        /// </summary> 
        public PriceValue? O { get; set; }

        /// <summary> 
        /// The highest price in the time-range represented by the candlestick. 
        /// </summary> 
        public PriceValue? H { get; set; }

        /// <summary> 
        /// The lowest price in the time-range represented by the candlestick. 
        /// </summary> 
        public PriceValue? L { get; set; }

        /// <summary> 
        /// The last (closing) price in the time-range represented by the 
        /// candlestick. 
        /// </summary> 
        public PriceValue? C { get; set; }
    }
}
