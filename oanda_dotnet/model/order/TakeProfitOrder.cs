using oanda_dotnet.model.pricing;
using oanda_dotnet.model.trade;
using oanda_dotnet.model.transaction;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A TakeProfitOrder is an order that is linked to an open Trade and created with a price threshold. 
    /// The Order will be filled (closing the Trade) by the first price that is equal to or better than the threshold. 
    /// A TakeProfitOrder cannot be used to open a new Position.
    /// </summary>
    public class TakeProfitOrder : ExitOrder
    {
        /// <summary> 
        /// The type of the Order. Always set to “TAKE_PROFIT” for Take Profit 
        /// Orders. 
        /// </summary> 
        public override OrderType Type => OrderType.TakeProfit;

        /// <summary> 
        /// The Id of the Trade to close when the price threshold is breached. 
        /// </summary> 
        [Required]
        public TradeId TradeId { get; set; }

        /// <summary> 
        /// The client Id of the Trade to be closed when the price threshold is 
        /// breached. 
        /// </summary> 
        public ClientId ClientTradeId { get; set; }

        /// <summary> 
        /// The price threshold specified for the TakeProfit Order. The associated 
        /// Trade will be closed by a market price that is equal to or better than 
        /// this threshold. 
        /// </summary> 
        [Required]
        public PriceValue Price { get; set; }
    }
}
