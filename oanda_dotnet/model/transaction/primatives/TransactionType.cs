using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The possible types of a Transaction
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionType
    {

        ///<summary>
        /// Account Create Transaction
        /// </summary>
        [EnumMember(Value = "CREATE")]
        Create,

        /// <summary>
        /// Account Close Transaction
        /// </summary>
        [EnumMember(Value = "CLOSE")]
        Close,

        /// <summary>
        /// Account Reopen Transaction
        /// </summary>
        [EnumMember(Value = "REOPEN")]
        Reopen,

        /// <summary>
        /// Client Configuration Transaction
        /// </summary>
        [EnumMember(Value = "CLIENT_CONFIGURE")]
        ClientConfigure,

        /// <summary>
        /// Client Configuration Reject Transaction
        /// </summary>
        [EnumMember(Value = "CLIENT_CONFIGURE_REJECT")]
        ClientConfigure_Reject,

        /// <summary>
        /// Transfer Funds Transaction
        /// </summary>
        [EnumMember(Value = "TRANSFER_FUNDS")]
        TransferFunds,

        /// <summary>
        /// Transfer Funds Reject Transaction
        /// </summary>
        [EnumMember(Value = "TRANSFER_FUNDS_REJECT")]
        TransferFundsReject,

        /// <summary>
        /// Market Order Transaction
        /// </summary>
        [EnumMember(Value = "MARKET_ORDER")]
        MarketOrder,

        /// <summary>
        /// Market Order Reject Transaction
        /// </summary>
        [EnumMember(Value = "MARKET_ORDER_REJECT")]
        MarketOrderReject,

        /// <summary>
        /// Fixed Price Order Transaction
        /// </summary>
        [EnumMember(Value = "FIXED_PRICE_ORDER")]
        FixedPriceOrder,

        /// <summary>
        /// Limit Order Transaction
        /// </summary>
        [EnumMember(Value = "LIMIT_ORDER")]
        LimitOrder,

        /// <summary>
        /// Limit Order Reject Transaction
        /// </summary>
        [EnumMember(Value = "LIMIT_ORDER_REJECT")]
        LimitOrderReject,

        /// <summary>
        /// Stop Order Transaction
        /// </summary>
        [EnumMember(Value = "STOP_ORDER")]
        StopOrder,

        /// <summary>
        /// Stop Order Reject Transaction
        /// </summary>
        [EnumMember(Value = "STOP_ORDER_REJECT")]
        StopOrderReject,

        /// <summary>
        /// Market if Touched Order Transaction
        /// </summary>
        [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER")]
        MarketIfTouchedOrder,

        /// <summary>
        /// Market if Touched Order Reject Transaction
        /// </summary>
        [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER_REJECT")]
        MarketIfTouchedOrderReject,

        /// <summary>
        /// Take Profit Order Transaction
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT_ORDER")]
        TakeProfitOrder,

        /// <summary>
        /// Take Profit Order Reject Transaction
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT_ORDER_REJECT")]
        TakeProfitOrderReject,

        /// <summary>
        /// Stop Loss Order Transaction
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ORDER")]
        StopLossOrder,

        /// <summary>
        /// Stop Loss Order Reject Transaction
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ORDER_REJECT")]
        StopLossOrderReject,

        /// <summary>
        /// Trailing Stop Loss Order Transaction
        /// </summary>
        [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER")]
        TrailingStopLossOrder,

        /// <summary>
        /// Trailing Stop Loss Order Reject Transaction
        /// </summary>
        [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER_REJECT")]
        TrailingStopLossOrderReject,

        /// <summary>
        /// Order Fill Transaction
        /// </summary>
        [EnumMember(Value = "ORDER_FILL")]
        OrderFill,

        /// <summary>
        /// Order Cancel Transaction
        /// </summary>
        [EnumMember(Value = "ORDER_CANCEL")]
        OrderCancel,

        /// <summary>
        /// Order Cancel Reject Transaction
        /// </summary>
        [EnumMember(Value = "ORDER_CANCEL_REJECT")]
        OrderCancelReject,

        /// <summary>
        /// Order Client Extensions Modify Transaction
        /// </summary>
        [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY")]
        OrderClientExtensionsModify,

        /// <summary>
        /// Order Client Extensions Modify Reject Transaction
        /// </summary>
        [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT")]
        OrderClientExtensionsModifyReject,

        /// <summary>
        /// Trade Client Extensions Modify Transaction
        /// </summary>
        [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY")]
        TradeClientExtensionsModify,

        /// <summary>
        /// Trade Client Extensions Modify Reject Transaction
        /// </summary>
        [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT")]
        TradeClientExtensionsModifyReject,

        /// <summary>
        /// Margin Call Enter Transaction
        /// </summary>
        [EnumMember(Value = "MARGIN_CALL_ENTER")]
        MarginCallEnter,

        /// <summary>
        /// Margin Call Extend Transaction
        /// </summary>
        [EnumMember(Value = "MARGIN_CALL_EXTEND")]
        MarginCallExtend,

        /// <summary>
        /// Margin Call Exit Transaction
        /// </summary>
        [EnumMember(Value = "MARGIN_CALL_EXIT")]
        MarginCallExit,

        /// <summary>
        /// Delayed Trade Closure Transaction
        /// </summary>
        [EnumMember(Value = "DELAYED_TRADE_CLOSURE")]
        DelayedTradeClosure,

        /// <summary>
        /// Daily Financing Transaction
        /// </summary>
        [EnumMember(Value = "DAILY_FINANCING")]
        DailyFinancing,

        /// <summary>
        /// Reset Resettable PL Transaction
        /// </summary>
        [EnumMember(Value = "RESET_RESETTABLE_PL")]
        ResetResettablePl
    }
}
