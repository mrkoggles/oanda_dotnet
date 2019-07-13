using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A CreateTransaction represents the creation of an Account.
    /// </summary>
    public class CreateTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “CREATE” in a
        /// CreateTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.Create;

        /// <summary>
        /// The Id of the Division that the Account is in
        /// </summary>
        public int DivisionId { get; set; }

        /// <summary>
        /// The Id of the Site that the Account was created at
        /// </summary>
        public int SiteId { get; set; }

        /// <summary>
        /// The Id of the user that the Account was created for
        /// </summary>
        public int AccountUserId { get; set; }

        /// <summary>
        /// The number of the Account within the site/division/user
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// The home currency of the Account
        /// </summary>
        public Currency HomeCurrency { get; set; }
    }


    /// <summary>
    /// A CloseTransaction represents the closing of an Account.
    /// </summary>
    public class CloseTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “CLOSE” in a CloseTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.Close;
    }


    /// <summary>
    /// A ReopenTransaction represents the re-opening of a closed Account.
    /// </summary>
    public class ReopenTransaction : Transaction
    {
        public override TransactionType Type => TransactionType.Reopen;
    }
}
