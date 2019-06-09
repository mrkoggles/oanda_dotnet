using oanda_dotnet.model.instrument;
using System.Collections.Generic;

namespace oanda_dotnet.model.instrument
{
    public abstract class InstrumentRestv20EndpointResponse : Restv20EndpointResponse { }
    public class GetInstrumentCandlesResponse : InstrumentRestv20EndpointResponse
    {
        public ICollection<Candlestick> Candles { get; set; }
        public CandlestickGranularity Granularity { get; set; }
        public InstrumentName Instrument { get; set; }
    }


    public class GetInstrumentOrderBookResponse : InstrumentRestv20EndpointResponse
    {
        public Book OrderBook { get; set; }
    }


    public class GetInstrumentPositionBookResponse : InstrumentRestv20EndpointResponse
    {
        public Book PositionBook { get; set; }
    }
}
