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
            (bool? IncludeMidpointCandles, bool? IncludeBidCandles, bool? IncludeAskCandles)? priceFilter = null,
            CandlestickGranularity? granulartiry = null,
            uint? count = null,
            (DateTime? From, DateTime? To)? dateFilter = null, 
            CandleSmoothingMethod? candleSmoothing = null,
            bool? includeFirst = null,
            (uint? DailyAlignment, TimeZone AlignmentTimeZone, DayOfWeek? WeeklyAlignment)? alignmentFilter = null)
                => Execute<GetInstrumentCandlesResponse>(new GetInstrumentCandlesEndpoint()
                    {
                        Instrument = instrument,
                        IncludeMidpointCandles = priceFilter?.IncludeMidpointCandles ?? false,
                        IncludeBidCandles = priceFilter?.IncludeBidCandles ?? false,
                        IncludeAskCandles = priceFilter?.IncludeAskCandles ?? false,
                        CandlestickGranularity = granulartiry,
                        Count = count,
                        From = dateFilter?.From,
                        To = dateFilter?.To,
                        Smooth = ((candleSmoothing ?? CandleSmoothingMethod.Unsmoothed) == CandleSmoothingMethod.Smoothed ? true : false),
                        IncludeFirst = includeFirst,
                        DailyAlignment = alignmentFilter?.DailyAlignment,
                        AlignmentTimeZone = alignmentFilter?.AlignmentTimeZone,
                        WeeklyAlignment = alignmentFilter?.WeeklyAlignment
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
