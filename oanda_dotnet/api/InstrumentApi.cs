using oanda_dotnet.client;
using oanda_dotnet.model.instrument;
using oanda_dotnet.model;
using System;

namespace oanda_dotnet.api
{
    public class InstrumentApi : Restv20Api<InstrumentRestv20EndpointRequest, InstrumentRestv20EndpointResponse>
    {
        public InstrumentApi(Restv20Client client) : base(client) { }

        public GetInstrumentCandlesResponse GetCandles(InstrumentName instrument,
            bool? includeMidpointCandles = null, bool? includeBidCandles = null, bool? includeAskCandles = null,
            CandlestickGranularity? granulartiry = null,
            uint? count = null,
            DateTime? from = null, DateTime? to = null, 
            CandleSmoothingMethod? candleSmoothing = null,
            bool? includeFirst = null,
            uint? dailyAlignment = null, TimeZone alignmentTimeZone = null, DayOfWeek? weeklyAlignment = null)
                => Execute<GetInstrumentCandlesResponse>(new GetInstrumentCandlesEndpoint()
                    {
                        Instrument = instrument,
                        IncludeMidpointCandles = includeMidpointCandles ?? false,
                        IncludeBidCandles = includeBidCandles ?? false,
                        IncludeAskCandles = includeAskCandles ?? false,
                        CandlestickGranularity = granulartiry,
                        Count = count,
                        From = from,
                        To = to,
                        Smooth = ((candleSmoothing ?? CandleSmoothingMethod.Unsmoothed) == CandleSmoothingMethod.Smoothed ? true : false),
                        IncludeFirst = includeFirst,
                        DailyAlignment = dailyAlignment,
                        AlignmentTimeZone = alignmentTimeZone,
                        WeeklyAlignment = weeklyAlignment
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
