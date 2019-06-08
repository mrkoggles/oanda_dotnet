namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// Details for the Market Order extensions specific to a Market Order placed that is part of a Market Order Margin Closeout in a client’s account
    /// </summary>
    public class MarketOrderMarginCloseout
    {
        /// <summary>
        /// The reason the Market Order was created to perform a margin closeout
        /// </summary>
        public MarketOrderMarginCloseoutReason Reason { get; set; }
    }
}
