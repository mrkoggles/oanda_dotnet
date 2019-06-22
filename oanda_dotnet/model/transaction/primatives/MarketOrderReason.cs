using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that the Market Order was created
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketOrderReason
    {
        /// <summary>
        /// The Market Order was created at the request of a client
        /// </summary>
        [EnumMember(Value ="CLIENT_ORDER")]
        ClientOrder,

        /// <summary>
        /// The Market Order was created to close a Trade at the request of a client
        /// </summary>
        [EnumMember(Value ="TRADE_CLOSE")]
        TradeClose,

        /// <summary>
        /// The Market Order was created to close a Position at the request of a client
        /// </summary>
        [EnumMember(Value ="POSITION_CLOSEOUT")]
        PositionCloseout,

        /// <summary>
        /// The Market Order was created as part of a Margin Closeout
        /// </summary>
        [EnumMember(Value ="MARGIN_CLOSEOUT")]
        MarginCloseout,

        /// <summary>
        /// The Market Order was created to close a trade marked for delayed closure
        /// </summary>
        [EnumMember(Value ="DELAYED_TRADE_CLOSE")]
        DelayedTradeClose
    }
}
