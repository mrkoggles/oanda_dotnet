namespace oanda_dotnet.model
{
    /// <summary>
    /// An InstrumentCommission represents an instrument-specific commission
    /// </summary>
    public class InstrumentCommission
    {
        /// <summary>
        /// The commission amount (in the Account’s home currency) charged per
        /// unitsTraded of the instrument
        /// </summary>
        public decimal Commission { get; set; }

        /// <summary>
        /// The number of units traded that the commission amount is based on.
        /// </summary>
        public decimal UnitsTraded { get; set; }

        /// <summary>
        /// The minimum commission amount (in the Account’s home currency) that is
        /// charged when an Order is filled for this instrument.
        /// </summary>
        public decimal MinimumCommission { get; set; }
    }
}
