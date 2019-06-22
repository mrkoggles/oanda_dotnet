using oanda_dotnet.model.pricing;
using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A TradeReduce object represents a Trade for an instrument that was reduced (either partially or fully) in an Account.
    /// It is found embedded in Transactions that affect the position of an instrument in the account, specifically the OrderFill Transaction.
    /// </summary>
    public class TradeReduce
    {
        /// <summary> 
        /// The Id of the Trade that was reduced or closed 
        /// </summary> 
        public TradeId TradeId { get; set; }

        /// <summary> 
        /// The number of units that the Trade was reduced by 
        /// </summary> 
        public decimal Units { get; set; }

        /// <summary> 
        /// The average price that the units were closed at. This price may be 
        /// clamped for guaranteed Stop Loss Orders. 
        /// </summary> 
        public PriceValue? Price { get; set; }

        /// <summary> 
        /// The PL realized when reducing the Trade 
        /// </summary> 
        public AccountUnits RealizedPL { get; set; }

        /// <summary> 
        /// The financing paId/collected when reducing the Trade 
        /// </summary> 
        public AccountUnits Financing { get; set; }

        /// <summary> 
        /// This is the fee that is charged for closing the Trade if it has a 
        /// guaranteed Stop Loss Order attached to it. 
        /// </summary> 
        public AccountUnits GuaranteedExecutionFee { get; set; }

        /// <summary> 
        /// The half spread cost for the trade reduce/close. This can be a positive 
        /// or negative value and is represented in the home currency of the Account. 
        /// </summary> 
        public AccountUnits HalfSpreadCost { get; set; }
    }
}
