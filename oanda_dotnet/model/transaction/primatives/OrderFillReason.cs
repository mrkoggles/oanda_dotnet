using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that an Order was filled
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderFillReason
    {

        ///<summary>
        /// The Order filled was a Limit Order
        /// </summary>
        [EnumMember(Value = " LIMIT_ORDER ")]
        LimitOrder,

        ///<summary>
        /// The Order filled was a Stop Order
        /// </summary>
        [EnumMember(Value = " STOP_ORDER ")]
        StopOrder,

        ///<summary>
        /// The Order filled was a Market-if-touched Order
        /// </summary>
        [EnumMember(Value = " MARKET_IF_TOUCHED_ORDER ")]
        MarketIfTouchedOrder,

        ///<summary>
        /// The Order filled was a Take Profit Order
        /// </summary>
        [EnumMember(Value = " TAKE_PROFIT_ORDER ")]
        TakeProfitOrder,

        ///<summary>
        /// The Order filled was a Stop Loss Order
        /// </summary>
        [EnumMember(Value = " STOP_LOSS_ORDER ")]
        StopLossOrder,

        ///<summary>
        /// The Order filled was a Trailing Stop Loss Order
        /// </summary>
        [EnumMember(Value = " TRAILING_STOP_LOSS_ORDER ")]
        TrailingStopLossOrder,

        ///<summary>
        /// The Order filled was a Market Order
        /// </summary>
        [EnumMember(Value = " MARKET_ORDER ")]
        MarketOrder,

        ///<summary>
        /// The Order filled was a Market Order used to explicitly close a Trade
        /// </summary>
        [EnumMember(Value = " MARKET_ORDER_TRADE_CLOSE ")]
        MarketOrderTradeClose,

        ///<summary>
        /// The Order filled was a Market Order used to explicitly close a Position
        /// </summary>
        [EnumMember(Value = " MARKET_ORDER_POSITION_CLOSEOUT ")]
        MarketOrderPositionCloseout,

        ///<summary>
        /// The Order filled was a Market Order used for a Margin Closeout
        /// </summary>
        [EnumMember(Value = " MARKET_ORDER_MARGIN_CLOSEOUT ")]
        MarketOrderMarginCloseout,

        ///<summary>
        /// The Order filled was a Market Order used for a delayed Trade close
        /// </summary>
        [EnumMember(Value = " MARKET_ORDER_DELAYED_TRADE_CLOSE ")]
        MarketOrderDelayedTradeClose
    }
}
