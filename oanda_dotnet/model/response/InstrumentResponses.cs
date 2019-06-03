using oanda_dotnet.model.instrument;
using System.Collections.Generic;

namespace oanda_dotnet.model
{
    public class GetInstrumentCandlesResponse
    {
        public ICollection<Candlestick> Candles { get; set; }
        public CandlestickGranularity Granularity { get; set; }
        public InstrumentName Instrument { get; set; }
    }


    public class GetInstrumentOrderBookResponse
    {
        public Book OrderBook { get; set; }
    }


    public class GetInstrumentPositionBookResponse
    {
        public Book PositionBook { get; set; }
    }
}
