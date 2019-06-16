namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A MarginCallEnterTransaction is created when an Account enters the margin call state.
    /// </summary>
    public class MarginCallEnterTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “MARGIN_CALL_ENTER” for an
        /// MarginCallEnterTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.MarginCallEnter;
    }


    /// <summary>
    /// A MarginCallExtendTransaction is created when the margin call state for an Account has been extended.
    /// </summary>
    public class MarginCallExtendTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “MARGIN_CALL_EXTEND” for an
        /// MarginCallExtendTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.MarginCallExtend;

        /// <summary>
        /// The number of the extensions to the Account’s current margin call that
        /// have been applied. This value will be set to 1 for the first
        /// MarginCallExtend Transaction
        /// </summary>
        public int ExtensionNumber { get; set; }
    }

    /// <summary>
    /// A MarginCallExitnterTransaction is created when an Account leaves the margin call state.
    /// </summary>
    public class MarginCallExitTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “MARGIN_CALL_EXIT” for an
        /// MarginCallExitTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.MarginCallExit;
    }
}
