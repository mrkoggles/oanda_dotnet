using oanda_dotnet.model.instrument;
using System.Collections.Generic;

namespace oanda_dotnet.model
{
    public class GetInstrumentCandlesResponse : Restv20Response
    {
        public ICollection<Candlestick> Candles { get; set; }
        public CandlestickGranularity Granularity { get; set; }
        public InstrumentName Instrument { get; set; }
    }


    public class GetInstrumentOrderBookResponse : Restv20Response
    {
        public Book OrderBook { get; set; }
    }


    public class GetInstrumentPositionBookResponse : Restv20Response
    {
        public Book PositionBook { get; set; }
    }
}
