namespace oanda_dotnet.model.position
{
    /// <summary>
    /// The dynamic (calculated) state of a Position
    /// </summary>
    public class CalculatedPositionState
    {
        /// <summary> 
        /// The Position’s Instrument. 
        /// </summary> 
        public InstrumentName Instrument { get; set; }

        /// <summary> 
        /// The Position’s net unrealized profit/loss 
        /// </summary> 
        public AccountUnits NetUnrealizedPL { get; set; }

        /// <summary> 
        /// The unrealized profit/loss of the Position’s long open Trades 
        /// </summary> 
        public AccountUnits LongUnrealizedPL { get; set; }

        /// <summary> 
        /// The unrealized profit/loss of the Position’s short open Trades 
        /// </summary> 
        public AccountUnits ShortUnrealizedPL { get; set; }

        /// <summary> 
        /// Margin currently used by the Position. 
        /// </summary> 
        public AccountUnits MarginUsed { get; set; }
    }
}
