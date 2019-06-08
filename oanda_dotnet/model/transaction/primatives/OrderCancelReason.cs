using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that an Order was cancelled.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderCancelReason
    {
        /// <summary>
        /// The Order was cancelled because at the time of filling, an unexpected internal server error occurred.
        /// </summary>
        [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
        InternalServerError,

        /// <summary>
        /// The Order was cancelled because at the time of filling the account was locked.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_LOCKED")]
        AccountLocked,

        /// <summary>
        /// The order was to be filled, however the account is configured to not allow new positions to be created.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_NEW_POSITIONS_LOCKED")]
        AccountNewPositionsLocked,

        /// <summary>
        /// Filling the Order wasn’t possible because it required the creation of a dependent Order and the Account is locked for Order creation.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_ORDER_CREATION_LOCKED")]
        AccountOrderCreationLocked,

        /// <summary>
        /// Filling the Order was not possible because the Account is locked for filling Orders.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_ORDER_FILL_LOCKED")]
        AccountOrderFillLocked,

        /// <summary>
        /// The Order was cancelled explicitly at the request of the client.
        /// </summary>
        [EnumMember(Value = "CLIENT_REQUEST")]
        ClientRequest,

        /// <summary>
        /// The Order cancelled because it is being migrated to another account.
        /// </summary>
        [EnumMember(Value = "MIGRATION")]
        Migration,

        /// <summary>
        /// Filling the Order wasn’t possible because the Order’s instrument was halted.
        /// </summary>
        [EnumMember(Value = "MARKET_HALTED")]
        MarketHalted,

        /// <summary>
        /// The Order is linked to an open Trade that was closed.
        /// </summary>
        [EnumMember(Value = "LINKED_TRADE_CLOSED")]
        LinkedTradeClosed,

        /// <summary>
        /// The time in force specified for this order has passed.
        /// </summary>
        [EnumMember(Value = "TIME_IN_FORCE_EXPIRED")]
        TimeInForceExpired,

        /// <summary>
        /// Filling the Order wasn’t possible because the Account had insufficient margin.
        /// </summary>
        [EnumMember(Value = "INSUFFICIENT_MARGIN")]
        InsufficientMargin,

        /// <summary>
        /// Filling the Order would have resulted in a a FIFO violation.
        /// </summary>
        [EnumMember(Value = "FIFO_VIOLATION")]
        FifoViolation,

        /// <summary>
        /// Filling the Order would have violated the Order’s price bound.
        /// </summary>
        [EnumMember(Value = "BOUNDS_VIOLATION")]
        BoundsViolation,

        /// <summary>
        /// The Order was cancelled for replacement at the request of the client.
        /// </summary>
        [EnumMember(Value = "CLIENT_REQUEST_REPLACED")]
        ClientRequestReplaced,

        /// <summary>
        /// Filling the Order wasn’t possible because enough liquidity available.
        /// </summary>
        [EnumMember(Value = "INSUFFICIENT_LIQUIDITY")]
        InsufficientLiquidity,

        /// <summary>
        /// Filling the Order would have resulted in the creation of a Take Profit Order with a GTD time in the past.
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT_ON_FILL_GTD_TIMESTAMP_IN_PAST")]
        TakeProfitOnFillGtdTimestampInPast,

        /// <summary>
        /// Filling the Order would result in the creation of a Take Profit Order that would have been filled immediately, closing the new Trade at a loss.
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT_ON_FILL_LOSS")]
        TakeProfitOnFillLoss,

        /// <summary>
        /// Filling the Order would result in the creation of a Take Profit Loss Order that would close the new Trade at a loss when filled.
        /// </summary>
        [EnumMember(Value = "LOSING_TAKE_PROFIT")]
        LosingTakeProfit,

        /// <summary>
        /// Filling the Order would have resulted in the creation of a Stop Loss Order with a GTD time in the past.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_GTD_TIMESTAMP_IN_PAST")]
        StopLossOnFillGtdTimestampInPast,

        /// <summary>
        /// Filling the Order would result in the creation of a Stop Loss Order that would have been filled immediately, closing the new Trade at a loss.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_LOSS")]
        StopLossOnFillLoss,

        /// <summary>
        /// Filling the Order would result in the creation of a Stop Loss Order whose price would be zero or negative due to the specified distance.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_PRICE_DISTANCE_MAXIMUM_EXCEEDED")]
        StopLossOnFillPriceDistanceMaximumExceeded,

        /// <summary>
        /// Filling the Order would not result in the creation of Stop Loss Order, however the Account’s configuration requires that all Trades have a Stop Loss Order attached to them.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_REQUIRED")]
        StopLossOnFillRequired,

        /// <summary>
        /// Filling the Order would not result in the creation of a guaranteed Stop Loss Order, however the Account’s configuration requires that all Trades have a guaranteed Stop Loss Order attached to them.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_GUARANTEED_REQUIRED")]
        StopLossOnFillGuaranteedRequired,

        /// <summary>
        /// Filling the Order would result in the creation of a guaranteed Stop Loss Order, however the Account’s configuration does not allow guaranteed Stop Loss Orders.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_GUARANTEED_NOT_ALLOWED")]
        StopLossOnFillGuaranteedNotAllowed,

        /// <summary>
        /// Filling the Order would result in the creation of a guaranteed Stop Loss Order with a distance smaller than the configured mininum distance.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_GUARANTEED_MINIMUM_DISTANCE_NOT_MET")]
        StopLossOnFillGuaranteedMinimumDistanceNotMet,

        /// <summary>
        /// Filling the Order would result in the creation of a guaranteed Stop Loss Order with trigger price and number of units that that violates the account’s guaranteed Stop Loss Order level restriction.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_GUARANTEED_LEVEL_RESTRICTION_EXCEEDED")]
        StopLossOnFillGuaranteedLevelRestrictionExceeded,

        /// <summary>
        /// Filling the Order would result in the creation of a guaranteed Stop Loss Order for a hedged Trade, however the Account’s configuration does not allow guaranteed Stop Loss Orders for hedged Trades/Positions.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_GUARANTEED_HEDGING_NOT_ALLOWED")]
        StopLossOnFillGuaranteedHedgingNotAllowed,

        /// <summary>
        /// Filling the Order would result in the creation of a Stop Loss Order whose TimeInForce value is invalid. A likely cause would be if the Account requires guaranteed stop loss orders and the TimeInForce value were not GTC.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_TIME_IN_FORCE_INVALID")]
        StopLossOnFillTimeInForceInvalid,

        /// <summary>
        /// Filling the Order would result in the creation of a Stop Loss Order whose TriggerCondition value is invalid. A likely cause would be if the stop loss order is guaranteed and the TimeInForce is not TRIGGER_DEFAULT or TRIGGER_BID for a long trade, or not TRIGGER_DEFAULT or TRIGGER_ASK for a short trade.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_TRIGGER_CONDITION_INVALID")]
        StopLossOnFillTriggerConditionInvalid,

        /// <summary>
        /// Filling the Order would result in the creation of a Take Profit Order whose price would be zero or negative due to the specified distance.
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT_ON_FILL_PRICE_DISTANCE_MAXIMUM_EXCEEDED")]
        TakeProfitOnFillPriceDistanceMaximumExceeded,

        /// <summary>
        /// Filling the Order would have resulted in the creation of a Trailing Stop Loss Order with a GTD time in the past.
        /// </summary>
        [EnumMember(Value = "TRAILING_STOP_LOSS_ON_FILL_GTD_TIMESTAMP_IN_PAST")]
        TrailingStopLossOnFillGtdTimestampInPast,

        /// <summary>
        /// Filling the Order would result in the creation of a new Open Trade with a client Trade ID already in use.
        /// </summary>
        [EnumMember(Value = "CLIENT_TRADE_ID_ALREADY_EXISTS")]
        ClientTradeIdAlreadyExists,

        /// <summary>
        /// Closing out a position wasn’t fully possible.
        /// </summary>
        [EnumMember(Value = "POSITION_CLOSEOUT_FAILED")]
        PositionCloseoutFailed,

        /// <summary>
        /// Filling the Order would cause the maximum open trades allowed for the Account to be exceeded.
        /// </summary>
        [EnumMember(Value = "OPEN_TRADES_ALLOWED_EXCEEDED")]
        OpenTradesAllowedExceeded,

        /// <summary>
        /// Filling the Order would have resulted in exceeding the number of pending Orders allowed for the Account.
        /// </summary>
        [EnumMember(Value = "PENDING_ORDERS_ALLOWED_EXCEEDED")]
        PendingOrdersAllowedExceeded,

        /// <summary>
        /// Filling the Order would have resulted in the creation of a Take Profit Order with a client Order ID that is already in use.
        /// </summary>
        [EnumMember(Value = "TAKE_PROFIT_ON_FILL_CLIENT_ORDER_ID_ALREADY_EXISTS")]
        TakeProfitOnFillClientOrderIdAlreadyExists,

        /// <summary>
        /// Filling the Order would have resulted in the creation of a Stop Loss Order with a client Order ID that is already in use.
        /// </summary>
        [EnumMember(Value = "STOP_LOSS_ON_FILL_CLIENT_ORDER_ID_ALREADY_EXISTS")]
        StopLossOnFillClientOrderIdAlreadyExists,

        /// <summary>
        /// Filling the Order would have resulted in the creation of a Trailing Stop Loss Order with a client Order ID that is already in use.
        /// </summary>
        [EnumMember(Value = "TRAILING_STOP_LOSS_ON_FILL_CLIENT_ORDER_ID_ALREADY_EXISTS")]
        TrailingStopLossOnFillClientOrderIdAlreadyExists,

        /// <summary>
        /// Filling the Order would have resulted in the Account’s maximum position size limit being exceeded for the Order’s instrument.
        /// </summary>
        [EnumMember(Value = "POSITION_SIZE_EXCEEDED")]
        PositionSizeExceeded,

        /// <summary>
        /// Filling the Order would result in the creation of a Trade, however there already exists an opposing (hedged) Trade that has a guaranteed Stop Loss Order attached to it. Guaranteed Stop Loss Orders cannot be combined with hedged positions.
        /// </summary>
        [EnumMember(Value = "HEDGING_GSLO_VIOLATION")]
        HedgingGsloViolation,

        /// <summary>
        /// Filling the order would cause the maximum position value allowed for the account to be exceeded. The Order has been cancelled as a result.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_POSITION_VALUE_LIMIT_EXCEEDED")]
        AccountPositionValueLimitExceeded
    }
}
