namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A ResetResettablePLTransaction represents the resetting of the Account’s resettable PL counters.
    /// </summary>
    public class ResetResettablePLTransaction : Transaction
    {
        /// <summary> 
        /// The Type of the Transaction. Always set to “RESET_RESETTABLE_PL” for an 
        /// ResetResettablePLTransaction. 
        /// </summary> 
        public override TransactionType Type => TransactionType.ResetResettablePl;
    }
}
