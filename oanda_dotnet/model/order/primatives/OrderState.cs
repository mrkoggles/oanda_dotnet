namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The current state of the Order.
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// The Order has been cancelled
        /// </summary>
        Cancelled,

        /// <summary>
        /// The Order has been filled
        /// </summary>
        Filled,

        /// <summary>
        /// The Order is currently pending execution
        /// </summary>
        Pending,

        /// <summary>
        /// The Order has been triggered
        /// </summary>
        Triggered
    }
}
