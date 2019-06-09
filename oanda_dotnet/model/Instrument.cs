namespace oanda_dotnet.model
{
    /// <summary>
    /// Full specification of an Instrument.
    /// </summary>
    public class Instrument
    {
        /// <summary>
        /// The name of the Instrument
        /// </summary>
        public InstrumentName Name { get; set; }

        /// <summary>
        /// The type of the Instrument
        /// </summary>
        public InstrumentType Type { get; set; }

        /// <summary>
        /// The display name of the Instrument
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The location of the “pip” for this instrument. The decimal position of
        /// the pip in this Instrument’s price can be found at 10 ^ pipLocation (e.g.
        /// -4 pipLocation results in a decimal pip position of 10 ^ -4 = 0.0001).
        /// </summary>
        public int PipLocation { get; set; }

        /// <summary>
        /// The number of decimal places that should be used to display prices for
        /// this instrument. (e.g. a displayPrecision of 5 would result in a price of
        /// “1” being displayed as “1.00000”)
        /// </summary>
        public int DisplayPrecision { get; set; }

        /// <summary>
        /// The amount of decimal places that may be provided when specifying the
        /// number of units traded for this instrument.
        /// </summary>
        public int TradeUnitsPrecision { get; set; }

        /// <summary>
        /// The smallest number of units allowed to be traded for this instrument.
        /// </summary>
        public decimal MinimumTradeSize { get; set; }

        /// <summary>
        /// The maximum trailing stop distance allowed for a trailing stop loss
        /// created for this instrument. Specified in price units.
        /// </summary>
        public decimal MaximumTrailingStopDistance { get; set; }

        /// <summary>
        /// The minimum trailing stop distance allowed for a trailing stop loss
        /// created for this instrument. Specified in price units.
        /// </summary>
        public decimal MinimumTrailingStopDistance { get; set; }

        /// <summary>
        /// The maximum position size allowed for this instrument. Specified in
        /// units.
        /// </summary>
        public decimal MaximumPositionSize { get; set; }

        /// <summary>
        /// The maximum units allowed for an Order placed for this instrument.
        /// Specified in units.
        /// </summary>
        public decimal MaximumOrderUnits { get; set; }

        /// <summary>
        /// The margin rate for this instrument.
        /// </summary>
        public decimal MarginRate { get; set; }

        /// <summary>
        /// The commission structure for this instrument.
        /// </summary>
        public InstrumentCommission Commission { get; set; }
    }
}
