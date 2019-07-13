using oanda_dotnet.model.account;
using System.Collections.Generic;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A DailyFinancingTransaction represents the daily payment/collection of financing for an Account.
    /// </summary>
    public class DailyFinancingTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “DAILY_FINANCING” for a
        /// DailyFinancingTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.DailyFinancing;

        /// <summary>
        /// The amount of financing paid/collected for the Account.
        /// </summary>
        public AccountUnits Financing { get; set; }

        /// <summary>
        /// The Account’s balance after daily financing.
        /// </summary>
        public AccountUnits AccountBalance { get; set; }

        /// <summary>
        /// The account financing mode at the time of the daily financing.
        /// </summary>
        public AccountFinancingMode AccountFinancingMode { get; set; }

        /// <summary>
        /// The financing paid/collected for each Position in the Account.
        /// </summary>
        public ICollection<PositionFinancing> PositionFinancings { get; set; }
    }
}
