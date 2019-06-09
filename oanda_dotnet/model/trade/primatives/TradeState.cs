namespace oanda_dotnet.model.trade
{
    /// <summary>
    /// The current state of the Trade.
    /// </summary>
    public enum TradeState
    {
        /// <summary>
        /// The Trade has been fully closed
        /// </summary>
        Closed,

        /// <summary>
        /// The Trade will be closed as soon as the trade’s instrument becomes tradeable
        /// </summary>
        ClosedWhenTradeable,

        /// <summary>
        /// The Trade is currently open
        /// </summary>
        Open
    }
}
