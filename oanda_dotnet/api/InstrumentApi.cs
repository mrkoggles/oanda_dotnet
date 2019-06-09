using oanda_dotnet.client;
using oanda_dotnet.model.instrument;
using oanda_dotnet.model;
using System;

namespace oanda_dotnet.api
{
    public class InstrumentApi : Restv20Api<InstrumentRestv20EndpointRequest, InstrumentRestv20EndpointResponse>
    {
        public InstrumentApi(Restv20Client client) : base(client) { }

        public GetInstrumentCandlesResponse GetCandles(InstrumentName instrument)
            => Execute<GetInstrumentCandlesResponse>(new GetInstrumentCandlesEndpoint()
            {
                Instrument = instrument
            });

        public GetInstrumentOrderBookResponse GetOrderBook(InstrumentName instrument, DateTime? time = null)
            => Execute<GetInstrumentOrderBookResponse>(new GetInstrumentOrderBookEndpoint()
            {
                Instrument = instrument,
                Time = time
            });

        public GetInstrumentPositionBookResponse GetPositionBook(InstrumentName instrument, DateTime? time = null)
            => Execute<GetInstrumentPositionBookResponse>(new GetInstrumentPositionBookEndpoint()
            {
                Instrument = instrument,
                Time = time
            });
    }
}
