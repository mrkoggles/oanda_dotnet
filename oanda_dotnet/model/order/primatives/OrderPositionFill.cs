namespace oanda_dotnet.model.order
{
    /// <summary>
    /// Specification of how Positions in the Account are modified when the Order is filled.
    /// </summary>
    public enum OrderPositionFill
    {
        ///<summary>
        /// When the Order is filled, only allow Positions to be opened or extended.
        /// </summary>
        OpenOnly,

        ///<summary>
        /// When the Order is filled, always fully reduce an existing Position before opening a new Position.
        /// </summary>
        ReduceFirst,

        ///<summary>
        /// When the Order is filled, only reduce an existing Position.
        /// </summary>
        ReduceOnly,

        ///<summary>
        /// When the Order is filled, use REDUCEFIRST behaviour for non-client hedging Accounts, and OPENONLY behaviour for client hedging Accounts.
        /// </summary>
        Default,

        ///<summary>
        /// The Order must be “Immediatedly paritally filled Or Cancelled”
        /// </summary>
        IOC
    }
}
