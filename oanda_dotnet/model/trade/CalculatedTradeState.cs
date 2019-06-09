namespace oanda_dotnet.model.trade
{
    /// <summary>
    /// The dynamic (calculated) state of an open Trade
    /// </summary>
    public class CalculatedTradeState
    {
        /// <summary> 
        /// The Trade’s ID. 
        /// </summary> 
        public TradeId Id { get; set; }

        /// <summary> 
        /// The Trade’s unrealized profit/loss. 
        /// </summary> 
        public AccountUnits UnrealizedPL { get; set; }

        /// <summary> 
        /// Margin currently used by the Trade. 
        /// </summary> 
        public AccountUnits MarginUsed { get; set; }
    }
}