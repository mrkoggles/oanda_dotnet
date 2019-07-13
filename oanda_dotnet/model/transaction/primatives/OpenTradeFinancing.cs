using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// OpenTradeFinancing is used to pay/collect daily financing charge for an open Trade within an Account
    /// </summary>
    public class OpenTradeFinancing
    {
        /// <summary>
        /// The ID of the Trade that financing is being paid/collected for.
        /// </summary>
        public TradeId TradeID { get; set; }

        /// <summary>
        /// The amount of financing paid/collected for the Trade.
        /// </summary>
        public AccountUnits Financing { get; set; }
    }
}
