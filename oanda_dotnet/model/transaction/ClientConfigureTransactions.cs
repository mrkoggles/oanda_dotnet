namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A ClientConfigureTransaction represents the configuration of an Account by a client.
    /// </summary>
    public class ClientConfigureTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “CLIENT_CONFIGURE” in a
        /// ClientConfigureTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.ClientConfigure;

        /// <summary>
        /// The client-provIded alias for the Account.
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// The margin rate override for the Account.
        /// </summary>
        public decimal MarginRate { get; set; }
    }

    /// <summary>
    /// A ClientConfigureRejectTransaction represents the reject of configuration of an Account by a client.
    /// </summary>
    public class ClientConfigureRejectTransaction : ClientConfigureTransaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “CLIENT_CONFIGURE_REJECT” in a
        /// ClientConfigureRejectTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.ClientConfigureReject;

        /// <summary>
        /// The reason that the Reject Transaction was created
        /// </summary>
        public TransactionRejectReason RejectReason { get; set; }
    }
}
