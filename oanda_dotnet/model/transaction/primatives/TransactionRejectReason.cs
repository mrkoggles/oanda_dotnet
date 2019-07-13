using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The reason that a Transaction was rejected.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionRejectReason
    {
        /// <summary>
        /// An unexpected internal server error has occurred
        /// </summary>
        [EnumMember(Value ="INTERNAL_SERVER_ERROR")]
        InternalServerError,

        /// <summary>
        /// The system was unable to determine the current price for the Order’s instrument
        /// </summary>
        [EnumMember(Value ="INSTRUMENT_PRICE_UNKNOWN")]
        InstrumentPriceUnknown,

        /// <summary>
        /// The Account is not active
        /// </summary>
        [EnumMember(Value ="ACCOUNT_NOT_ACTIVE")]
        AccountNotActive,

        /// <summary>
        /// The Account is locked
        /// </summary>
        [EnumMember(Value ="ACCOUNT_LOCKED")]
        AccountLocked,

        /// <summary>
        /// The Account is locked for Order creation
        /// </summary>
        [EnumMember(Value ="ACCOUNT_ORDER_CREATION_LOCKED")]
        AccountOrderCreationLocked,

        /// <summary>
        /// The Account is locked for configuration
        /// </summary>
        [EnumMember(Value ="ACCOUNT_CONFIGURATION_LOCKED")]
        AccountConfigurationLocked,

        /// <summary>
        /// The Account is locked for deposits
        /// </summary>
        [EnumMember(Value ="ACCOUNT_DEPOSIT_LOCKED")]
        AccountDepositLocked,

        /// <summary>
        /// The Account is locked for withdrawals
        /// </summary>
        [EnumMember(Value ="ACCOUNT_WITHDRAWAL_LOCKED")]
        AccountWithdrawalLocked,

        /// <summary>
        /// The Account is locked for Order cancellation
        /// </summary>
        [EnumMember(Value ="ACCOUNT_ORDER_CANCEL_LOCKED")]
        AccountOrderCancelLocked,

        /// <summary>
        /// The instrument specified is not tradeable by the Account
        /// </summary>
        [EnumMember(Value ="INSTRUMENT_NOT_TRADEABLE")]
        InstrumentNotTradeable,

        /// <summary>
        /// Creating the Order would result in the maximum number of allowed pending Orders being exceeded
        /// </summary>
        [EnumMember(Value ="PENDING_ORDERS_ALLOWED_EXCEEDED")]
        PendingOrdersAllowedExceeded,

        /// <summary>
        /// Neither the Order ID nor client Order ID are specified
        /// </summary>
        [EnumMember(Value ="ORDER_ID_UNSPECIFIED")]
        OrderIdUnspecified,

        /// <summary>
        /// The Order specified does not exist
        /// </summary>
        [EnumMember(Value ="ORDER_DOESNT_EXIST")]
        OrderDoesntExist,

        /// <summary>
        /// The Order ID and client Order ID specified do not identify the same Order
        /// </summary>
        [EnumMember(Value ="ORDER_IDENTIFIER_INCONSISTENCY")]
        OrderIdentifierInconsistency,

        /// <summary>
        /// Neither the Trade ID nor client Trade ID are specified
        /// </summary>
        [EnumMember(Value ="TRADE_ID_UNSPECIFIED")]
        TradeIdUnspecified,

        /// <summary>
        /// The Trade specified does not exist
        /// </summary>
        [EnumMember(Value ="TRADE_DOESNT_EXIST")]
        TradeDoesntExist,

        /// <summary>
        /// The Trade ID and client Trade ID specified do not identify the same Trade
        /// </summary>
        [EnumMember(Value ="TRADE_IDENTIFIER_INCONSISTENCY")]
        TradeIdentifierInconsistency,

        /// <summary>
        /// The Account had insufficient margin to perform the action specified. One possible reason for this is due to the creation or modification of a guaranteed StopLoss Order.
        /// </summary>
        [EnumMember(Value ="INSUFFICIENT_MARGIN")]
        InsufficientMargin,

        /// <summary>
        /// Order instrument has not been specified
        /// </summary>
        [EnumMember(Value ="INSTRUMENT_MISSING")]
        InstrumentMissing,

        /// <summary>
        /// The instrument specified is unknown
        /// </summary>
        [EnumMember(Value ="INSTRUMENT_UNKNOWN")]
        InstrumentUnknown,

        /// <summary>
        /// Order units have not been not specified
        /// </summary>
        [EnumMember(Value ="UNITS_MISSING")]
        UnitsMissing,

        /// <summary>
        /// Order units specified are invalid
        /// </summary>
        [EnumMember(Value ="UNITS_INVALID")]
        UnitsInvalid,

        /// <summary>
        /// The units specified contain more precision than is allowed for the Order’s instrument
        /// </summary>
        [EnumMember(Value ="UNITS_PRECISION_EXCEEDED")]
        UnitsPrecisionExceeded,

        /// <summary>
        /// The units specified exceeds the maximum number of units allowed
        /// </summary>
        [EnumMember(Value ="UNITS_LIMIT_EXCEEDED")]
        UnitsLimitExceeded,

        /// <summary>
        /// The units specified is less than the minimum number of units required
        /// </summary>
        [EnumMember(Value ="UNITS_MIMIMUM_NOT_MET")]
        UnitsMimimumNotMet,

        /// <summary>
        /// The price has not been specified
        /// </summary>
        [EnumMember(Value ="PRICE_MISSING")]
        PriceMissing,

        /// <summary>
        /// The price specifed is invalid
        /// </summary>
        [EnumMember(Value ="PRICE_INVALID")]
        PriceInvalid,

        /// <summary>
        /// The price specified contains more precision than is allowed for the instrument
        /// </summary>
        [EnumMember(Value ="PRICE_PRECISION_EXCEEDED")]
        PricePrecisionExceeded,

        /// <summary>
        /// The price distance has not been specified
        /// </summary>
        [EnumMember(Value ="PRICE_DISTANCE_MISSING")]
        PriceDistanceMissing,

        /// <summary>
        /// The price distance specifed is invalid
        /// </summary>
        [EnumMember(Value ="PRICE_DISTANCE_INVALID")]
        PriceDistanceInvalid,

        /// <summary>
        /// The price distance specified contains more precision than is allowed for the instrument
        /// </summary>
        [EnumMember(Value ="PRICE_DISTANCE_PRECISION_EXCEEDED")]
        PriceDistancePrecisionExceeded,

        /// <summary>
        /// The price distance exceeds that maximum allowed amount
        /// </summary>
        [EnumMember(Value ="PRICE_DISTANCE_MAXIMUM_EXCEEDED")]
        PriceDistanceMaximumExceeded,

        /// <summary>
        /// The price distance does not meet the minimum allowed amount
        /// </summary>
        [EnumMember(Value ="PRICE_DISTANCE_MINIMUM_NOT_MET")]
        PriceDistanceMinimumNotMet,

        /// <summary>
        /// The TimeInForce field has not been specified
        /// </summary>
        [EnumMember(Value ="TIME_IN_FORCE_MISSING")]
        TimeInForceMissing,

        /// <summary>
        /// The TimeInForce specified is invalid
        /// </summary>
        [EnumMember(Value ="TIME_IN_FORCE_INVALID")]
        TimeInForceInvalid,

        /// <summary>
        /// The TimeInForce is GTD but no GTD timestamp is provided
        /// </summary>
        [EnumMember(Value ="TIME_IN_FORCE_GTD_TIMESTAMP_MISSING")]
        TimeInForceGtdTimestampMissing,

        /// <summary>
        /// The TimeInForce is GTD but the GTD timestamp is in the past
        /// </summary>
        [EnumMember(Value ="TIME_IN_FORCE_GTD_TIMESTAMP_IN_PAST")]
        TimeInForceGtdTimestampInPast,

        /// <summary>
        /// The price bound specified is invalid
        /// </summary>
        [EnumMember(Value ="PRICE_BOUND_INVALID")]
        PriceBoundInvalid,

        /// <summary>
        /// The price bound specified contains more precision than is allowed for the Order’s instrument
        /// </summary>
        [EnumMember(Value ="PRICE_BOUND_PRECISION_EXCEEDED")]
        PriceBoundPrecisionExceeded,

        /// <summary>
        /// Multiple Orders on fill share the same client Order ID
        /// </summary>
        [EnumMember(Value ="ORDERS_ON_FILL_DUPLICATE_CLIENT_ORDER_IDS")]
        OrdersOnFillDuplicateClientOrderIds,

        /// <summary>
        /// The Order does not support Trade on fill client extensions because it cannot create a new Trade
        /// </summary>
        [EnumMember(Value ="TRADE_ON_FILL_CLIENT_EXTENSIONS_NOT_SUPPORTED")]
        TradeOnFillClientExtensionsNotSupported,

        /// <summary>
        /// The client Order ID specified is invalid
        /// </summary>
        [EnumMember(Value ="CLIENT_ORDER_ID_INVALID")]
        ClientOrderIdInvalid,

        /// <summary>
        /// The client Order ID specified is already assigned to another pending Order
        /// </summary>
        [EnumMember(Value ="CLIENT_ORDER_ID_ALREADY_EXISTS")]
        ClientOrderIdAlreadyExists,

        /// <summary>
        /// The client Order tag specified is invalid
        /// </summary>
        [EnumMember(Value ="CLIENT_ORDER_TAG_INVALID")]
        ClientOrderTagInvalid,

        /// <summary>
        /// The client Order comment specified is invalid
        /// </summary>
        [EnumMember(Value ="CLIENT_ORDER_COMMENT_INVALID")]
        ClientOrderCommentInvalid,

        /// <summary>
        /// The client Trade ID specified is invalid
        /// </summary>
        [EnumMember(Value ="CLIENT_TRADE_ID_INVALID")]
        ClientTradeIdInvalid,

        /// <summary>
        /// The client Trade ID specifed is already assigned to another open Trade
        /// </summary>
        [EnumMember(Value ="CLIENT_TRADE_ID_ALREADY_EXISTS")]
        ClientTradeIdAlreadyExists,

        /// <summary>
        /// The client Trade tag specified is invalid
        /// </summary>
        [EnumMember(Value ="CLIENT_TRADE_TAG_INVALID")]
        ClientTradeTagInvalid,

        /// <summary>
        /// The client Trade comment is invalid
        /// </summary>
        [EnumMember(Value ="CLIENT_TRADE_COMMENT_INVALID")]
        ClientTradeCommentInvalid,

        /// <summary>
        /// The OrderFillPositionAction field has not been specified
        /// </summary>
        [EnumMember(Value ="ORDER_FILL_POSITION_ACTION_MISSING")]
        OrderFillPositionActionMissing,

        /// <summary>
        /// The OrderFillPositionAction specified is invalid
        /// </summary>
        [EnumMember(Value ="ORDER_FILL_POSITION_ACTION_INVALID")]
        OrderFillPositionActionInvalid,

        /// <summary>
        /// The TriggerCondition field has not been specified
        /// </summary>
        [EnumMember(Value ="TRIGGER_CONDITION_MISSING")]
        TriggerConditionMissing,

        /// <summary>
        /// The TriggerCondition specified is invalid
        /// </summary>
        [EnumMember(Value ="TRIGGER_CONDITION_INVALID")]
        TriggerConditionInvalid,

        /// <summary>
        /// The OrderFillPositionAction field has not been specified
        /// </summary>
        [EnumMember(Value ="ORDER_PARTIAL_FILL_OPTION_MISSING")]
        OrderPartialFillOptionMissing,

        /// <summary>
        /// The OrderFillPositionAction specified is invalid.
        /// </summary>
        [EnumMember(Value ="ORDER_PARTIAL_FILL_OPTION_INVALID")]
        OrderPartialFillOptionInvalid,

        /// <summary>
        /// When attempting to reissue an order (currently only a MarketIfTouched) that was immediately partially filled, it is not possible to create a correct pending Order.
        /// </summary>
        [EnumMember(Value ="INVALID_REISSUE_IMMEDIATE_PARTIAL_FILL")]
        InvalidReissueImmediatePartialFill,

        /// <summary>
        /// A Take Profit Order for the specified Trade already exists
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ORDER_ALREADY_EXISTS")]
        TakeProfitOrderAlreadyExists,

        /// <summary>
        /// The Take Profit on fill specified does not provide a price
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_PRICE_MISSING")]
        TakeProfitOnFillPriceMissing,

        /// <summary>
        /// The Take Profit on fill specified contains an invalid price
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_PRICE_INVALID")]
        TakeProfitOnFillPriceInvalid,

        /// <summary>
        /// The Take Profit on fill specified contains a price with more precision than is allowed by the Order’s instrument
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_PRICE_PRECISION_EXCEEDED")]
        TakeProfitOnFillPricePrecisionExceeded,

        /// <summary>
        /// The Take Profit on fill specified does not provide a TimeInForce
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_TIME_IN_FORCE_MISSING")]
        TakeProfitOnFillTimeInForceMissing,

        /// <summary>
        /// The Take Profit on fill specifies an invalid TimeInForce
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_TIME_IN_FORCE_INVALID")]
        TakeProfitOnFillTimeInForceInvalid,

        /// <summary>
        /// The Take Profit on fill specifies a GTD TimeInForce but does not provide a GTD timestamp
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_GTD_TIMESTAMP_MISSING")]
        TakeProfitOnFillGtdTimestampMissing,

        /// <summary>
        /// The Take Profit on fill specifies a GTD timestamp that is in the past
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_GTD_TIMESTAMP_IN_PAST")]
        TakeProfitOnFillGtdTimestampInPast,

        /// <summary>
        /// The Take Profit on fill client Order ID specified is invalid
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_CLIENT_ORDER_ID_INVALID")]
        TakeProfitOnFillClientOrderIdInvalid,

        /// <summary>
        /// The Take Profit on fill client Order tag specified is invalid
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_CLIENT_ORDER_TAG_INVALID")]
        TakeProfitOnFillClientOrderTagInvalid,

        /// <summary>
        /// The Take Profit on fill client Order comment specified is invalid
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_CLIENT_ORDER_COMMENT_INVALID")]
        TakeProfitOnFillClientOrderCommentInvalid,

        /// <summary>
        /// The Take Profit on fill specified does not provide a TriggerCondition
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_TRIGGER_CONDITION_MISSING")]
        TakeProfitOnFillTriggerConditionMissing,

        /// <summary>
        /// The Take Profit on fill specifies an invalid TriggerCondition
        /// </summary>
        [EnumMember(Value ="TAKE_PROFIT_ON_FILL_TRIGGER_CONDITION_INVALID")]
        TakeProfitOnFillTriggerConditionInvalid,

        /// <summary>
        /// A Stop Loss Order for the specified Trade already exists
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_ALREADY_EXISTS")]
        StopLossOrderAlreadyExists,

        /// <summary>
        /// An attempt was made to to create a non-guaranteed stop loss order in an account that requires all stop loss orders to be guaranteed.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_REQUIRED")]
        StopLossOrderGuaranteedRequired,

        /// <summary>
        /// An attempt to create a guaranteed stop loss order with a price that is within the current tradeable spread.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_PRICE_WITHIN_SPREAD")]
        StopLossOrderGuaranteedPriceWithinSpread,

        /// <summary>
        /// An attempt was made to create a guaranteed Stop Loss Order, however the Account’s configuration does not allow guaranteed Stop Loss Orders.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_NOT_ALLOWED")]
        StopLossOrderGuaranteedNotAllowed,

        /// <summary>
        /// An attempt was made to create a guaranteed Stop Loss Order when the market was halted.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_HALTED_CREATE_VIOLATION")]
        StopLossOrderGuaranteedHaltedCreateViolation,

        /// <summary>
        /// An attempt was made to re-create a guaranteed Stop Loss Order with a tighter fill price when the market was halted.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_HALTED_TIGHTEN_VIOLATION")]
        StopLossOrderGuaranteedHaltedTightenViolation,

        /// <summary>
        /// An attempt was made to create a guaranteed Stop Loss Order on a hedged Trade (ie there is an existing open Trade in the opposing direction), however the Account’s configuration does not allow guaranteed Stop Loss Orders for hedged Trades/Positions.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_HEDGING_NOT_ALLOWED")]
        StopLossOrderGuaranteedHedgingNotAllowed,

        /// <summary>
        /// An attempt was made to create a guaranteed Stop Loss Order, however the distance between the current price and the trigger price does not meet the Account’s configured minimumGuaranteedStopLossDistance.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_MINIMUM_DISTANCE_NOT_MET")]
        StopLossOrderGuaranteedMinimumDistanceNotMet,

        /// <summary>
        /// An attempt was made to cancel a Stop Loss Order, however the Account’s configuration requires every Trade have an associated Stop Loss Order.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_NOT_CANCELABLE")]
        StopLossOrderNotCancelable,

        /// <summary>
        /// An attempt was made to cancel and replace a Stop Loss Order, however the Account’s configuration prevents the modification of Stop Loss Orders.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_NOT_REPLACEABLE")]
        StopLossOrderNotReplaceable,

        /// <summary>
        /// An attempt was made to create a guaranteed Stop Loss Order, however doing so would exceed the Account’s configured guaranteed StopLoss Order level restriction volume.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_GUARANTEED_LEVEL_RESTRICTION_EXCEEDED")]
        StopLossOrderGuaranteedLevelRestrictionExceeded,

        /// <summary>
        /// The Stop Loss Order request contains both the price and distance fields.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_PRICE_AND_DISTANCE_BOTH_SPECIFIED")]
        StopLossOrderPriceAndDistanceBothSpecified,

        /// <summary>
        /// The Stop Loss Order request contains neither the price nor distance fields.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ORDER_PRICE_AND_DISTANCE_BOTH_MISSING")]
        StopLossOrderPriceAndDistanceBothMissing,

        /// <summary>
        /// An attempt to create a pending Order was made with no Stop Loss Order on fill specified and the Account’s configuration requires that every Trade have an associated Stop Loss Order.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_REQUIRED_FOR_PENDING_ORDER")]
        StopLossOnFillRequiredForPendingOrder,

        /// <summary>
        /// An attempt to create a pending Order was made with a Stop Loss Order on fill that was explicitly configured to be guaranteed, however the Account’s configuration does not allow guaranteed Stop Loss Orders.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_GUARANTEED_NOT_ALLOWED")]
        StopLossOnFillGuaranteedNotAllowed,

        /// <summary>
        /// An attempt to create a pending Order was made with a Stop Loss Order on fill that was explicitly configured to be not guaranteed, however the Account’s configuration requires guaranteed Stop Loss Orders.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_GUARANTEED_REQUIRED")]
        StopLossOnFillGuaranteedRequired,

        /// <summary>
        /// The Stop Loss on fill specified does not provide a price
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_PRICE_MISSING")]
        StopLossOnFillPriceMissing,

        /// <summary>
        /// The Stop Loss on fill specifies an invalid price
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_PRICE_INVALID")]
        StopLossOnFillPriceInvalid,

        /// <summary>
        /// The Stop Loss on fill specifies a price with more precision than is allowed by the Order’s instrument
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_PRICE_PRECISION_EXCEEDED")]
        StopLossOnFillPricePrecisionExceeded,

        /// <summary>
        /// An attempt to create a pending Order was made with the distance between the guaranteed Stop Loss Order on fill’s price and the pending Order’s price is less than the Account’s configured minimum guaranteed stop loss distance.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_GUARANTEED_MINIMUM_DISTANCE_NOT_MET")]
        StopLossOnFillGuaranteedMinimumDistanceNotMet,

        /// <summary>
        /// An attempt to create a pending Order was made with a guaranteed Stop Loss Order on fill configured, and the Order’s units exceed the Account’s configured guaranteed StopLoss Order level restriction volume.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_GUARANTEED_LEVEL_RESTRICTION_EXCEEDED")]
        StopLossOnFillGuaranteedLevelRestrictionExceeded,

        /// <summary>
        /// The Stop Loss on fill distance is invalid
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_DISTANCE_INVALID")]
        StopLossOnFillDistanceInvalid,

        /// <summary>
        /// The Stop Loss on fill price distance exceeds the maximum allowed amount
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_PRICE_DISTANCE_MAXIMUM_EXCEEDED")]
        StopLossOnFillPriceDistanceMaximumExceeded,

        /// <summary>
        /// The Stop Loss on fill distance contains more precision than is allowed by the instrument
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_DISTANCE_PRECISION_EXCEEDED")]
        StopLossOnFillDistancePrecisionExceeded,

        /// <summary>
        /// The Stop Loss on fill contains both the price and distance fields.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_PRICE_AND_DISTANCE_BOTH_SPECIFIED")]
        StopLossOnFillPriceAndDistanceBothSpecified,

        /// <summary>
        /// The Stop Loss on fill contains neither the price nor distance fields.
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_PRICE_AND_DISTANCE_BOTH_MISSING")]
        StopLossOnFillPriceAndDistanceBothMissing,

        /// <summary>
        /// The Stop Loss on fill specified does not provide a TimeInForce
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_TIME_IN_FORCE_MISSING")]
        StopLossOnFillTimeInForceMissing,

        /// <summary>
        /// The Stop Loss on fill specifies an invalid TimeInForce
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_TIME_IN_FORCE_INVALID")]
        StopLossOnFillTimeInForceInvalid,

        /// <summary>
        /// The Stop Loss on fill specifies a GTD TimeInForce but does not provide a GTD timestamp
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_GTD_TIMESTAMP_MISSING")]
        StopLossOnFillGtdTimestampMissing,

        /// <summary>
        /// The Stop Loss on fill specifies a GTD timestamp that is in the past
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_GTD_TIMESTAMP_IN_PAST")]
        StopLossOnFillGtdTimestampInPast,

        /// <summary>
        /// The Stop Loss on fill client Order ID specified is invalid
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_CLIENT_ORDER_ID_INVALID")]
        StopLossOnFillClientOrderIdInvalid,

        /// <summary>
        /// The Stop Loss on fill client Order tag specified is invalid
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_CLIENT_ORDER_TAG_INVALID")]
        StopLossOnFillClientOrderTagInvalid,

        /// <summary>
        /// The Stop Loss on fill client Order comment specified is invalid
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_CLIENT_ORDER_COMMENT_INVALID")]
        StopLossOnFillClientOrderCommentInvalid,

        /// <summary>
        /// The Stop Loss on fill specified does not provide a TriggerCondition
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_TRIGGER_CONDITION_MISSING")]
        StopLossOnFillTriggerConditionMissing,

        /// <summary>
        /// The Stop Loss on fill specifies an invalid TriggerCondition
        /// </summary>
        [EnumMember(Value ="STOP_LOSS_ON_FILL_TRIGGER_CONDITION_INVALID")]
        StopLossOnFillTriggerConditionInvalid,

        /// <summary>
        /// A Trailing Stop Loss Order for the specified Trade already exists
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ORDER_ALREADY_EXISTS")]
        TrailingStopLossOrderAlreadyExists,

        /// <summary>
        /// The Trailing Stop Loss on fill specified does not provide a distance
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_PRICE_DISTANCE_MISSING")]
        TrailingStopLossOnFillPriceDistanceMissing,

        /// <summary>
        /// The Trailing Stop Loss on fill distance is invalid
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_PRICE_DISTANCE_INVALID")]
        TrailingStopLossOnFillPriceDistanceInvalid,

        /// <summary>
        /// The Trailing Stop Loss on fill distance contains more precision than is allowed by the instrument
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_PRICE_DISTANCE_PRECISION_EXCEEDED")]
        TrailingStopLossOnFillPriceDistancePrecisionExceeded,

        /// <summary>
        /// The Trailing Stop Loss on fill price distance exceeds the maximum allowed amount
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_PRICE_DISTANCE_MAXIMUM_EXCEEDED")]
        TrailingStopLossOnFillPriceDistanceMaximumExceeded,

        /// <summary>
        /// The Trailing Stop Loss on fill price distance does not meet the minimum allowed amount
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_PRICE_DISTANCE_MINIMUM_NOT_MET")]
        TrailingStopLossOnFillPriceDistanceMinimumNotMet,

        /// <summary>
        /// The Trailing Stop Loss on fill specified does not provide a TimeInForce
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_TIME_IN_FORCE_MISSING")]
        TrailingStopLossOnFillTimeInForceMissing,

        /// <summary>
        /// The Trailing Stop Loss on fill specifies an invalid TimeInForce
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_TIME_IN_FORCE_INVALID")]
        TrailingStopLossOnFillTimeInForceInvalid,

        /// <summary>
        /// The Trailing Stop Loss on fill TimeInForce is specified as GTD but no GTD timestamp is provided
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_GTD_TIMESTAMP_MISSING")]
        TrailingStopLossOnFillGtdTimestampMissing,

        /// <summary>
        /// The Trailing Stop Loss on fill GTD timestamp is in the past
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_GTD_TIMESTAMP_IN_PAST")]
        TrailingStopLossOnFillGtdTimestampInPast,

        /// <summary>
        /// The Trailing Stop Loss on fill client Order ID specified is invalid
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_CLIENT_ORDER_ID_INVALID")]
        TrailingStopLossOnFillClientOrderIdInvalid,

        /// <summary>
        /// The Trailing Stop Loss on fill client Order tag specified is invalid
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_CLIENT_ORDER_TAG_INVALID")]
        TrailingStopLossOnFillClientOrderTagInvalid,

        /// <summary>
        /// The Trailing Stop Loss on fill client Order comment specified is invalid
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_CLIENT_ORDER_COMMENT_INVALID")]
        TrailingStopLossOnFillClientOrderCommentInvalid,

        /// <summary>
        /// A client attempted to create either a Trailing Stop Loss order or an order with a Trailing Stop Loss On Fill specified, which may not yet be supported.
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ORDERS_NOT_SUPPORTED")]
        TrailingStopLossOrdersNotSupported,

        /// <summary>
        /// The Trailing Stop Loss on fill specified does not provide a TriggerCondition
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_TRIGGER_CONDITION_MISSING")]
        TrailingStopLossOnFillTriggerConditionMissing,

        /// <summary>
        /// The Tailing Stop Loss on fill specifies an invalid TriggerCondition
        /// </summary>
        [EnumMember(Value ="TRAILING_STOP_LOSS_ON_FILL_TRIGGER_CONDITION_INVALID")]
        TrailingStopLossOnFillTriggerConditionInvalid,

        /// <summary>
        /// The request to close a Trade does not specify a full or partial close
        /// </summary>
        [EnumMember(Value ="CLOSE_TRADE_TYPE_MISSING")]
        CloseTradeTypeMissing,

        /// <summary>
        /// The request to close a Trade partially did not specify the number of units to close
        /// </summary>
        [EnumMember(Value ="CLOSE_TRADE_PARTIAL_UNITS_MISSING")]
        CloseTradePartialUnitsMissing,

        /// <summary>
        /// The request to partially close a Trade specifies a number of units that exceeds the current size of the given Trade
        /// </summary>
        [EnumMember(Value ="CLOSE_TRADE_UNITS_EXCEED_TRADE_SIZE")]
        CloseTradeUnitsExceedTradeSize,

        /// <summary>
        /// The Position requested to be closed out does not exist
        /// </summary>
        [EnumMember(Value ="CLOSEOUT_POSITION_DOESNT_EXIST")]
        CloseoutPositionDoesntExist,

        /// <summary>
        /// The request to closeout a Position was specified incompletely
        /// </summary>
        [EnumMember(Value ="CLOSEOUT_POSITION_INCOMPLETE_SPECIFICATION")]
        CloseoutPositionIncompleteSpecification,

        /// <summary>
        /// A partial Position closeout request specifies a number of units that exceeds the current Position
        /// </summary>
        [EnumMember(Value ="CLOSEOUT_POSITION_UNITS_EXCEED_POSITION_SIZE")]
        CloseoutPositionUnitsExceedPositionSize,

        /// <summary>
        /// The request to closeout a Position could not be fully satisfied
        /// </summary>
        [EnumMember(Value ="CLOSEOUT_POSITION_REJECT")]
        CloseoutPositionReject,

        /// <summary>
        /// The request to partially closeout a Position did not specify the number of units to close.
        /// </summary>
        [EnumMember(Value ="CLOSEOUT_POSITION_PARTIAL_UNITS_MISSING")]
        CloseoutPositionPartialUnitsMissing,

        /// <summary>
        /// The markup group ID provided is invalid
        /// </summary>
        [EnumMember(Value ="MARKUP_GROUP_ID_INVALID")]
        MarkupGroupIdInvalid,

        /// <summary>
        /// The PositionAggregationMode provided is not supported/valid.
        /// </summary>
        [EnumMember(Value ="POSITION_AGGREGATION_MODE_INVALID")]
        PositionAggregationModeInvalid,

        /// <summary>
        /// No configuration parameters provided
        /// </summary>
        [EnumMember(Value ="ADMIN_CONFIGURE_DATA_MISSING")]
        AdminConfigureDataMissing,

        /// <summary>
        /// The margin rate provided is invalid
        /// </summary>
        [EnumMember(Value ="MARGIN_RATE_INVALID")]
        MarginRateInvalid,

        /// <summary>
        /// The margin rate provided would cause an immediate margin closeout
        /// </summary>
        [EnumMember(Value ="MARGIN_RATE_WOULD_TRIGGER_CLOSEOUT")]
        MarginRateWouldTriggerCloseout,

        /// <summary>
        /// The account alias string provided is invalid
        /// </summary>
        [EnumMember(Value ="ALIAS_INVALID")]
        AliasInvalid,

        /// <summary>
        /// No configuration parameters provided
        /// </summary>
        [EnumMember(Value ="CLIENT_CONFIGURE_DATA_MISSING")]
        ClientConfigureDataMissing,

        /// <summary>
        /// The margin rate provided would cause the Account to enter a margin call state.
        /// </summary>
        [EnumMember(Value ="MARGIN_RATE_WOULD_TRIGGER_MARGIN_CALL")]
        MarginRateWouldTriggerMarginCall,

        /// <summary>
        /// Funding is not possible because the requested transfer amount is invalid
        /// </summary>
        [EnumMember(Value ="AMOUNT_INVALID")]
        AmountInvalid,

        /// <summary>
        /// The Account does not have sufficient balance to complete the funding request
        /// </summary>
        [EnumMember(Value ="INSUFFICIENT_FUNDS")]
        InsufficientFunds,

        /// <summary>
        /// Funding amount has not been specified
        /// </summary>
        [EnumMember(Value ="AMOUNT_MISSING")]
        AmountMissing,

        /// <summary>
        /// Funding reason has not been specified
        /// </summary>
        [EnumMember(Value ="FUNDING_REASON_MISSING")]
        FundingReasonMissing,

        /// <summary>
        /// Neither Order nor Trade on Fill client extensions were provided for modification
        /// </summary>
        [EnumMember(Value ="CLIENT_EXTENSIONS_DATA_MISSING")]
        ClientExtensionsDataMissing,

        /// <summary>
        /// The Order to be replaced has a different type than the replacing Order.
        /// </summary>
        [EnumMember(Value ="REPLACING_ORDER_INVALID")]
        ReplacingOrderInvalid,

        /// <summary>
        /// The replacing Order refers to a different Trade than the Order that is being replaced.
        /// </summary>
        [EnumMember(Value ="REPLACING_TRADE_ID_INVALID")]
        ReplacingTradeIdInvalid
    }
}
