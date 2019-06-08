using oanda_dotnet.model.pricing;
using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A TradeOpen object represents a Trade for an instrument that was opened in an Account. 
    /// It is found embedded in Transactions that affect the position of an instrument in the Account, specifically the OrderFill Transaction.
    /// </summary>
    public class TradeOpen
    {
        /// <summary> 
        /// The ID of the Trade that was opened 
        /// </summary> 
        public TradeId TradeId { get; set; }

        /// <summary> 
        /// The number of units opened by the Trade 
        /// </summary> 
        public decimal Units { get; set; }

        /// <summary> 
        /// The average price that the units were opened at. 
        /// </summary> 
        public PriceValue Price { get; set; }

        /// <summary> 
        /// This is the fee charged for opening the trade if it has a guaranteed Stop 
        /// Loss Order attached to it. 
        /// </summary> 
        public AccountUnits GuaranteedExecutionFee { get; set; }

        /// <summary> 
        /// The client extensions for the newly opened Trade 
        /// </summary> 
        public ClientExtensions ClientExtensions { get; set; }

        /// <summary> 
        /// The half spread cost for the trade open. This can be a positive or 
        /// negative value and is represented in the home currency of the Account. 
        /// </summary> 
        public AccountUnits HalfSpreadCost { get; set; }

        /// <summary> 
        /// The margin required at the time the Trade was created. Note, this is the 
        /// ‘pure’ margin required, it is not the ‘effective’ margin used that 
        /// factors in the trade risk if a GSLO is attached to the trade. 
        /// </summary> 
        public AccountUnits InitialMarginRequired { get; set; }
    }
}
