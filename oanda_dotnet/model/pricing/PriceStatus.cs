namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// The status of the Price.
    /// </summary>
    public enum PriceStatus
    {
        /// <summary>
        /// The Instrument of the price is invalid or there is no valid Price for the Instrument.
        /// </summary>
        Invalid,

        /// <summary>
        /// The Instrument’s price is not tradeable.
        /// </summary>
        NonTradeable,

        /// <summary>
        /// The Instrument’s price is tradeable.
        /// </summary>
        Tradeable
    }
}