using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The type of the Order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderType
    {
        /// <summary>
        /// A Market Order
        /// </summary>
        [EnumMember(Value = "MARKET")]
        Market,

        /// <summary>
        /// A Limit Order
        /// </summary>
        [EnumMember(Value = "LIMIT")]
        Limit,

        /// <summary>
        /// A Stop Order
        /// </summary>
        [EnumMember(Value = "STOP")]
        Stop,

        /// <summary>
        /// A Market-if-touched Order
        /// </summary>
        [EnumMember(Value = "MARKET_IF_TOUCHED")]
        MarketIfTouched,

        /// <summary>
        /// A Take Profit Order
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT")]
        TakeProfit,

        /// <summary>
        /// A Stop Loss Order
        /// </summary>
        [EnumMember(Value = "STOP_LOSS")]
        StopLoss,

        /// <summary>
        /// A Trailing Stop Loss Order
        /// </summary>
        [EnumMember(Value = "TRAILING_STOP_LOSS")]
        TrailingStopLoss,

        /// <summary>
        /// A Fixed Price Order
        /// </summary>
        [EnumMember(Value = "FIXED_PRICE")]
        FixedPrice
    }
}
