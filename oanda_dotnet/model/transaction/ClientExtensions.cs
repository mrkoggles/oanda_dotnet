namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A ClientExtensions object allows a client to attach a clientID, tag and comment to Orders and Trades in their Account.  
    /// Do not set, modify, or delete this field if your account is associated with MT4.
    /// </summary>
    public class ClientExtensions
    {
        /// <summary>
        /// The Client ID of the Order/Trade
        /// </summary>
        public ClientId Id { get; set; }

        /// <summary>
        /// A tag associated with the Order/Trade
        /// </summary>
        public ClientTag Tag { get; set; }

        /// <summary>
        /// A comment associated with the Order/Trade
        /// </summary>
        public ClientComment Comment { get; set; }
    }
}
