namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The unique Transaction identifier within each Account.
    /// </summary>
    public struct TransactionId
    {
        private string _transactionId;

        public static implicit operator string(TransactionId transactionId) => transactionId._transactionId;
        public static implicit operator TransactionId(string transactionId) => new TransactionId { _transactionId = transactionId };
    }
}
