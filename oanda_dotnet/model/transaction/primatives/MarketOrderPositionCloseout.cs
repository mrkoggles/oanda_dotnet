namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A MarketOrderPositionCloseout specifies the extensions to a Market Order when it has been created to closeout a specific Position.
    /// </summary>
    public class MarketOrderPositionCloseout
    {
        /// <summary>
        /// The instrument of the Position being closed out.
        /// </summary>
        public InstrumentName Instrument { get; set; }

        /// <summary>
        /// Indication of how much of the Position to close. Either “ALL”, or a
        /// DecimalNumber reflection a partial close of the Trade. The DecimalNumber
        /// must always be positive, and represent a number that doesn’t exceed the
        /// absolute size of the Position.
        /// </summary>
        public string Units { get; set; }
    }
}
