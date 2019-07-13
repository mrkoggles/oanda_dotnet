namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A TransferFundsTransaction represents the transfer of funds in/out of an Account.
    /// </summary>
    public class TransferFundsTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “TRANSFER_FUNDS” in a
        /// TransferFundsTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.TransferFunds;

        /// <summary>
        /// The amount to deposit/withdraw from the Account in the Account’s home
        /// currency. A positive value indicates a deposit, a negative value
        /// indicates a withdrawal.
        /// </summary>
        public AccountUnits Amount { get; set; }

        /// <summary>
        /// The reason that an Account is being funded.
        /// </summary>
        public FundingReason FundingReason { get; set; }

        /// <summary>
        /// An optional comment that may be attached to a fund transfer for audit
        /// purposes
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// The Account’s balance after funds are transferred.
        /// </summary>
        public AccountUnits AccountBalance { get; set; }
    }


    /// <summary>
    /// A TransferFundsRejectTransaction represents the rejection of the transfer of funds in/out of an Account.
    /// </summary>
    public class TransferFundsRejectTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “TRANSFER_FUNDS_REJECT” in a
        /// TransferFundsRejectTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.TransferFundsReject;

        /// <summary>
        /// The amount to deposit/withdraw from the Account in the Account’s home
        /// currency. A positive value indicates a deposit, a negative value
        /// indicates a withdrawal.
        /// </summary>
        public AccountUnits Amount { get; set; }

        /// <summary>
        /// The reason that an Account is being funded.
        /// </summary>
        public FundingReason FundingReason { get; set; }

        /// <summary>
        /// An optional comment that may be attached to a fund transfer for audit
        /// purposes
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// The reason that the Reject Transaction was created
        /// </summary>
        public TransactionRejectReason RejectReason { get; set; }
    }
}
