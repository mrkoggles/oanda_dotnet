namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The type of the Order.
    /// </summary>
    public enum OrderType
    {
        ///<summary>
        /// A Market Order
        /// </summary>
        Market,

        ///<summary>
        /// A Limit Order
        /// </summary>
        Limit,

        ///<summary>
        /// A Stop Order
        /// </summary>
        Stop,

        ///<summary>
        /// A Market-if-touched Order
        /// </summary>
        MarketIfTouched,

        ///<summary>
        /// A Take Profit Order
        /// </summary>
        TakeProfit,

        ///<summary>
        /// A Stop Loss Order
        /// </summary>
        StopLoss,

        ///<summary>
        /// A Trailing Stop Loss Order
        /// </summary>
        TrailingStopLoss,

        ///<summary>
        /// A Fixed Price Order
        /// </summary>
        FixedPrice,
    }
}
