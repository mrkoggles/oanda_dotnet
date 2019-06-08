namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The time-in-force of an Order. 
    /// TimeInForce describes how long an Order should remain pending before being automatically cancelled by the execution system.
    /// </summary>
    public enum TimeInForce
    {
        ///<summary>
        /// The Order is “Good until Cancelled”
        /// </summary>
        GTC,

        ///<summary>
        /// The Order is “Good until Date” and will be cancelled at the provided time
        /// </summary>
        GTD,

        ///<summary>
        /// The Order is “Good For Day” and will be cancelled at 5pm New York time
        /// </summary>
        GFD,

        ///<summary>
        /// The Order must be immediately “Filled Or Killed”
        /// </summary>
        FOK,

        ///<summary>
        /// The Order must be “Immediatedly paritally Filled or Cancelled”
        /// </summary>
        IOC,
    }
}
