namespace oanda_dotnet.model.position
{
    /// <summary>
    /// The specification of a Position within an Account.
    /// </summary>
    public class Position
    {
        /// <summary> 
        /// The Position’s Instrument. 
        /// </summary> 
        public InstrumentName Instrument { get; set; }

        /// <summary> 
        /// Profit/loss realized by the Position over the lifetime of the Account. 
        /// </summary> 
        public AccountUnits Pl { get; set; }

        /// <summary> 
        /// The unrealized profit/loss of all open Trades that contribute to this 
        /// Position. 
        /// </summary> 
        public AccountUnits UnrealizedPL { get; set; }

        /// <summary> 
        /// Margin currently used by the Position. 
        /// </summary> 
        public AccountUnits MarginUsed { get; set; }

        /// <summary> 
        /// Profit/loss realized by the Position since the Account’s resettablePL was 
        /// last reset by the client. 
        /// </summary> 
        public AccountUnits ResettablePL { get; set; }

        /// <summary> 
        /// The total amount of financing paid/collected for this instrument over the 
        /// lifetime of the Account. 
        /// </summary> 
        public AccountUnits Financing { get; set; }

        /// <summary> 
        /// The total amount of commission paid for this instrument over the lifetime 
        /// of the Account. 
        /// </summary> 
        public AccountUnits Commission { get; set; }

        /// <summary> 
        /// The total amount of fees charged over the lifetime of the Account for the 
        /// execution of guaranteed Stop Loss Orders for this instrument. 
        /// </summary> 
        public AccountUnits GuaranteedExecutionFees { get; set; }

        /// <summary> 
        /// The details of the long side of the Position. 
        /// </summary> 
        public PositionSide Long { get; set; }

        /// <summary> 
        /// The details of the short side of the Position. 
        /// </summary> 
        public PositionSide Short { get; set; }
    }
}
