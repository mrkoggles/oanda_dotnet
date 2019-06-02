namespace oanda_dotnet.model.order
{
    /// <summary>
    /// Representation of many units of an Instrument are available to be traded for both long and short Orders.
    /// </summary>
    public class UnitsAvailableDetails
    {
        /// <summary>
        /// The units available for long Orders.
        /// </summary>
        public decimal Long { get; set; }

        /// <summary>
        /// The units available for short Orders.
        /// </summary>
        public decimal Short { get; set; }
    }
}