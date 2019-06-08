using oanda_dotnet.model.account;
using oanda_dotnet.model.order;
using oanda_dotnet.model.pricing;
using System;
using System.Collections.Generic;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// An OrderFillTransaction represents the filling of an Order in the client’s Account.
    /// </summary>
    public class OrderFillTransaction
    {
        /// <summary> 
        /// The Transaction’s Identifier. 
        /// </summary> 
        public TransactionId Id { get; set; }

        /// <summary> 
        /// The date/time when the Transaction was created. 
        /// </summary> 
        public System.DateTime Time { get; set; }

        /// <summary> 
        /// The Id of the user that initiated the creation of the Transaction. 
        /// </summary> 
        public int UserId { get; set; }

        /// <summary> 
        /// The Id of the Account the Transaction was created for. 
        /// </summary> 
        public AccountId AccountId { get; set; }

        /// <summary> 
        /// The Id of the “batch” that the Transaction belongs to. Transactions in 
        /// the same batch are applied to the Account simultaneously. 
        /// </summary> 
        public TransactionId BatchId { get; set; }

        /// <summary> 
        /// The Request Id of the request which generated the transaction. 
        /// </summary> 
        public RequestId RequestId { get; set; }

        /// <summary> 
        /// The Type of the Transaction. Always set to “ORDER_FILL” for an 
        /// OrderFillTransaction. 
        /// </summary> 
        public TransactionType Type => TransactionType.OrderFill;

        /// <summary> 
        /// The Id of the Order filled. 
        /// </summary> 
        public OrderId OrderId { get; set; }

        /// <summary> 
        /// The client Order Id of the Order filled (only provIded if the client has 
        /// assigned one). 
        /// </summary> 
        public ClientId ClientOrderId { get; set; }

        /// <summary> 
        /// The name of the filled Order’s instrument. 
        /// </summary> 
        public InstrumentName Instrument { get; set; }

        /// <summary> 
        /// The number of units filled by the Order. 
        /// </summary> 
        public decimal Units { get; set; }

        /// <summary> 
        /// This is the conversion factor in effect for the Account at the time of 
        /// the OrderFill for converting any gains realized in Instrument quote units 
        /// into units of the Account’s home currency. 
        /// </summary> 
        public decimal GainQuoteHomeConversionFactor { get; set; }

        /// <summary> 
        /// This is the conversion factor in effect for the Account at the time of 
        /// the OrderFill for converting any losses realized in Instrument quote 
        /// units into units of the Account’s home currency. 
        /// </summary> 
        public decimal LossQuoteHomeConversionFactor { get; set; }

        /// <summary> 
        /// This field is now deprecated and should no longer be used. The indivIdual 
        /// tradesClosed, tradeReduced and tradeOpened fields contain the 
        /// exact/official price each unit was filled at. 
        /// </summary> 
        [Obsolete("Deprecated: Will be removed in a future API update. ")]
        public PriceValue Price { get; set; }

        /// <summary> 
        /// The price in effect for the account at the time of the Order fill. 
        /// </summary> 
        public ClientPrice FullPrice { get; set; }

        /// <summary> 
        /// The reason that an Order was filled 
        /// </summary> 
        public OrderFillReason Reason { get; set; }

        /// <summary> 
        /// The profit or loss incurred when the Order was filled. 
        /// </summary> 
        public AccountUnits Pl { get; set; }

        /// <summary> 
        /// The financing paId or collected when the Order was filled. 
        /// </summary> 
        public AccountUnits Financing { get; set; }

        /// <summary> 
        /// The commission charged in the Account’s home currency as a result of 
        /// filling the Order. The commission is always represented as a positive 
        /// quantity of the Account’s home currency, however it reduces the balance 
        /// in the Account. 
        /// </summary> 
        public AccountUnits Commission { get; set; }

        /// <summary> 
        /// The total guaranteed execution fees charged for all Trades opened, closed 
        /// or reduced with guaranteed Stop Loss Orders. 
        /// </summary> 
        public AccountUnits GuaranteedExecutionFee { get; set; }

        /// <summary> 
        /// The Account’s balance after the Order was filled. 
        /// </summary> 
        public AccountUnits AccountBalance { get; set; }

        /// <summary> 
        /// The Trade that was opened when the Order was filled (only provIded if 
        /// filling the Order resulted in a new Trade). 
        /// </summary> 
        public TradeOpen TradeOpened { get; set; }

        /// <summary> 
        /// The Trades that were closed when the Order was filled (only provIded if 
        /// filling the Order resulted in a closing open Trades). 
        /// </summary> 
        public ICollection<TradeReduce> TradesClosed { get; set; }

        /// <summary> 
        /// The Trade that was reduced when the Order was filled (only provIded if 
        /// filling the Order resulted in reducing an open Trade). 
        /// </summary> 
        public TradeReduce TradeReduced { get; set; }

        /// <summary> 
        /// The half spread cost for the OrderFill, which is the sum of the 
        /// halfSpreadCost values in the tradeOpened, tradesClosed and tradeReduced 
        /// fields. This can be a positive or negative value and is represented in 
        /// the home currency of the Account. 
        /// </summary> 
        public AccountUnits HalfSpreadCost { get; set; }
    }
}
