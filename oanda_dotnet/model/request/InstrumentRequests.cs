using oanda_dotnet.model.instrument;
using RestSharp;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.request
{
    /// <summary>
    /// Fetch candlestick data for an instrument.
    /// </summary>
    public sealed class GetInstrumentCandlesRequest : Restv20Request
    {
        private uint? _count;
        private uint? _dailyAlignment;


        public override string Endpoint => "/v3/instruments/{instrument}/candles";
        public override Method Method => Method.GET;


        public bool IncludeMidpointCandles { get; set; }
        public bool IncludeBidCandles { get; set; }
        public bool IncludeAskCandles { get; set; }


        /// <summary>
        /// Format of DateTime fields in the request and response. 
        /// </summary>
        [Required]
        [RequestParameter(Name = "Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
        public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


        /// <summary>
        /// Name of the Instrument
        /// </summary>
        [Required]
        [RequestParameter(Name = "instrument", Type = ParameterType.UrlSegment)]
        public InstrumentName? Instrument { get; set; }


        /// <summary>
        /// The Price component(s) to get candlestick data for. 
        /// Can contain any combination of the characters “M” (midpoint candles) 
        /// “B” (bid candles) and “A” (ask candles). 
        /// [default=M] 
        /// </summary>
        [RequestParameter(Name = "price", Type = ParameterType.QueryString)]
        public string Price =>
            string.Concat(
                (IncludeAskCandles ? "A" : null),
                (IncludeBidCandles ? "B": null),
                (IncludeMidpointCandles ? "M" : null));


        /// <summary>
        /// The granularity of the candlesticks to fetch
        /// [default=S5] 
        /// </summary>
        [RequestParameter(Name = "granularity", Type = ParameterType.QueryString)]
        public CandlestickGranularity? CandlestickGranularity { get; set; }


        /// <summary>
        /// The number of candlesticks to return in the reponse. 
        /// Count should not be specified if both the start and end parameters are provided, 
        /// as the time range combined with the graularity will determine the number of candlesticks to return.
        /// [default=500, maximum=5000] 
        /// </summary>
        [RequestParameter(Name = "count", Type = ParameterType.QueryString)]
        public uint? Count
        {
            get => _count;
            set => _count = (value == null ? null : (uint?)Math.Min((int)value, 5000));
        }


        /// <summary>
        /// The start of the time range to fetch candlesticks for. 
        /// </summary>
        [RequestParameter(Name = "from", Type = ParameterType.QueryString)]
        public System.DateTime? From { get; set; }


        /// <summary>
        /// The end of the time range to fetch candlesticks for. 
        /// </summary>
        [RequestParameter(Name = "to", Type = ParameterType.QueryString)]
        public System.DateTime? To { get; set; }


        /// <summary>
        /// A flag that controls whether the candlestick is “smoothed” or not. 
        /// A smoothed candlestick uses the previous candle’s close price as its open price, 
        /// while an unsmoothed candlestick uses the first price from its time range as its open price. 
        /// </summary>
        [RequestParameter(Name = "smooth", Type = ParameterType.QueryString)]
        public bool? Smooth { get; set; }


        /// <summary>
        /// A flag that controls whether the candlestick that is covered by the from time should be included in the results. 
        /// This flag enables clients to use the timestamp of the last completed candlestick received 
        /// to poll for future candlesticks but avoid receiving the previous candlestick repeatedly.
        /// [default=True] 
        /// </summary>
        [RequestParameter(Name = "includeFirst", Type = ParameterType.QueryString)]
        public bool? IncludeFirst { get; set; }


        /// <summary>
        /// The hour of the day (in the specified timezone) to use for granularities that have daily alignments. 
        /// [default=17, minimum=0, maximum=23] 
        /// </summary>
        [RequestParameter(Name = "dailyAlignment", Type = ParameterType.QueryString)]
        public uint? DailyAlignment
        {
            get => _dailyAlignment;
            set => _dailyAlignment = (value == null ? null : (uint?)Math.Min((int)value, 23));
        }


        /// <summary>
        /// The timezone to use for the dailyAlignment parameter. 
        /// Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone. 
        /// Note that the returned times will still be represented in UTC. 
        /// [default=America/New_York] 
        /// </summary>
        [RequestParameter(Name = "alignmentTimezone", Type = ParameterType.QueryString)]
        public TimeZone AlignmentTimeZone { get; set; }


        /// <summary>
        /// The day of the week used for granularities that have weekly alignment.
        /// [default=Friday] 
        /// </summary>
        [RequestParameter(Name = "weeklyAlignment", Type = ParameterType.QueryString)]
        public DayOfWeek? WeeklyAlignment { get; set; }
    }


    /// <summary>
    /// Fetch an order book for an instrument.
    /// </summary>
    public sealed class GetInstrumentOrderBookRequest : Restv20Request
    {
        public override string Endpoint => "/v3/instruments/{instrument}/orderBook";
        public override Method Method => Method.GET;


        /// <summary>
        /// Format of DateTime fields in the request and response. 
        /// </summary>
        [Required]
        [RequestParameter(Name = "Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
        public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


        /// <summary>
        /// Name of the Instrument
        /// </summary>
        [Required]
        [RequestParameter(Name = "instrument", Type = ParameterType.UrlSegment)]
        public InstrumentName? Instrument { get; set; }


        /// <summary>
        /// The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched. 
        /// </summary>
        [RequestParameter(Name = "time", Type = ParameterType.UrlSegment)]
        public System.DateTime? Time { get; set; }
    }
}
