using oanda_dotnet.model.instrument;
using System.Collections.Generic;

namespace oanda_dotnet.model.instrument
{
    public class GetInstrumentCandlesResponse : Restv20EndpointResponse
    {
        public ICollection<Candlestick> Candles { get; set; }
        public CandlestickGranularity Granularity { get; set; }
        public InstrumentName Instrument { get; set; }
    }


    public class GetInstrumentOrderBookResponse : Restv20EndpointResponse
    {
        public Book OrderBook { get; set; }
    }


    public class GetInstrumentPositionBookResponse : Restv20EndpointResponse
    {
        public Book PositionBook { get; set; }
    }
}
