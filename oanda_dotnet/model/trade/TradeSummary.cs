using oanda_dotnet.model.order;
using oanda_dotnet.model.pricing;
using oanda_dotnet.model.transaction;
using System;
using System.Collections.Generic;

namespace oanda_dotnet.model.trade
{
    /// <summary>
    /// The summary of a Trade within an Account. This representation does not provIde the full details of the Trade’s dependent Orders.
    /// </summary>
    public class TradeSummary
    {
        /// <summary> 
        /// The Trade’s Identifier, unique within the Trade’s Account. 
        /// </summary> 
        public TradeId Id { get; set; }

        /// <summary> 
        /// The Trade’s Instrument. 
        /// </summary> 
        public InstrumentName Instrument { get; set; }

        /// <summary> 
        /// The execution price of the Trade. 
        /// </summary> 
        public PriceValue Price { get; set; }

        /// <summary> 
        /// The date/time when the Trade was opened. 
        /// </summary> 
        public DateTime OpenTime { get; set; }

        /// <summary> 
        /// The current state of the Trade. 
        /// </summary> 
        public TradeState State { get; set; }

        /// <summary> 
        /// The initial size of the Trade. Negative values indicate a short Trade, 
        /// and positive values indicate a long Trade. 
        /// </summary> 
        public decimal InitialUnits { get; set; }

        /// <summary> 
        /// The margin required at the time the Trade was created. Note, this is the 
        /// ‘pure’ margin required, it is not the ‘effective’ margin used that 
        /// factors in the trade risk if a GSLO is attached to the trade. 
        /// </summary> 
        public AccountUnits InitialMarginRequired { get; set; }

        /// <summary> 
        /// The number of units currently open for the Trade. This value is reduced 
        /// to 0.0 as the Trade is closed. 
        /// </summary> 
        public decimal CurrentUnits { get; set; }

        /// <summary> 
        /// The total profit/loss realized on the closed portion of the Trade. 
        /// </summary> 
        public AccountUnits RealizedPL { get; set; }

        /// <summary> 
        /// The unrealized profit/loss on the open portion of the Trade. 
        /// </summary> 
        public AccountUnits UnrealizedPL { get; set; }

        /// <summary> 
        /// Margin currently used by the Trade. 
        /// </summary> 
        public AccountUnits MarginUsed { get; set; }

        /// <summary> 
        /// The average closing price of the Trade. Only present if the Trade has 
        /// been closed or reduced at least once. 
        /// </summary> 
        public PriceValue AverageClosePrice { get; set; }

        /// <summary> 
        /// The Ids of the Transactions that have closed portions of this Trade. 
        /// </summary> 
        public ICollection<TransactionId> ClosingTransactionIds { get; set; }

        /// <summary> 
        /// The financing paId/collected for this Trade. 
        /// </summary> 
        public AccountUnits Financing { get; set; }

        /// <summary> 
        /// The date/time when the Trade was fully closed. Only provIded for Trades 
        /// whose state is CLOSED. 
        /// </summary> 
        public DateTime CloseTime { get; set; }

        /// <summary> 
        /// The client extensions of the Trade. 
        /// </summary> 
        public ClientExtensions ClientExtensions { get; set; }

        /// <summary> 
        /// Id of the Trade’s Take Profit Order, only provIded if such an Order 
        /// exists. 
        /// </summary> 
        public OrderId TakeProfitOrderId { get; set; }

        /// <summary> 
        /// Id of the Trade’s Stop Loss Order, only provIded if such an Order exists. 
        /// </summary> 
        public OrderId StopLossOrderId { get; set; }

        /// <summary> 
        /// Id of the Trade’s Trailing Stop Loss Order, only provIded if such an 
        /// Order exists. 
        /// </summary> 
        public OrderId TrailingStopLossOrderId { get; set; }
    }
}
