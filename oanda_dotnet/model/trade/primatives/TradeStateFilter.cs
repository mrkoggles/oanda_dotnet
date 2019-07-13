namespace oanda_dotnet.model.trade
{
    /// <summary>
    /// The state to filter the Trades by
    /// </summary>
    public enum TradeStateFilter
    {
        /// <summary>
        /// The Trades that are in any of the possible states listed above.
        /// </summary>
        All,

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
