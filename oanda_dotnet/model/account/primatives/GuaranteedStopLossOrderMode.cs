namespace oanda_dotnet.model.account
{
    /// <summary>
    /// The overall behaviour of the Account regarding guaranteed Stop Loss Orders.
    /// </summary>
    public enum GuaranteedStopLossOrderMode
    {
        /// <summary>
        /// The Account is able, but not required to have guaranteed Stop Loss Orders for open Trades.
        /// </summary>
        Allowed,

        /// <summary>
        /// The Account is not permitted to create guaranteed Stop Loss Orders.
        /// </summary>
        Disabled,

        /// <summary>
        /// The Account is required to have guaranteed Stop Loss Orders for all open Trades.
        /// </summary>
        Required
    }
}
