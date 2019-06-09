using oanda_dotnet.model.transaction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.account
{
    public abstract class AccountRestv20EndpointResponse : Restv20EndpointResponse { }

    public sealed class GetAccountsResponse : AccountRestv20EndpointResponse
    {
        /// <summary>
        /// The list of Accounts the client is authorized to access and their
        /// associated properties.
        /// </summary>
        public ICollection<AccountProperties> Accounts { get; set; }
    }

    public sealed class GetAccountResponse : AccountRestv20EndpointResponse
    {
        /// <summary>
        /// The full details of the requested Account.
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class GetAccountSummaryResponse : AccountRestv20EndpointResponse
    {
        /// <summary>
        /// The summary of the requested Account.
        /// </summary>
        public AccountSummary Account { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class GetAccountInstrumentsResponse : AccountRestv20EndpointResponse
    {
        /// <summary>
        /// The requested list of instruments.
        /// </summary>
        public ICollection<Instrument> Instruments { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class ConfigureAccountResponse : AccountRestv20EndpointResponse
    {
        /// <summary>
        /// The transaction that configures the Account.
        /// </summary>
        public ClientConfigureTransaction ClientConfigureTransaction { get; set; }

        /// <summary>
        /// The Id of the last Transaction created for the Account.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class ConfigureAccountErrorResponse : AccountRestv20EndpointResponse
    {
        /// <summary>
        /// The transaction that rejects the configuration of the Account.
        /// </summary>
        public ClientConfigureRejectTransaction ClientConfigureRejectTransaction { get; set; }

        /// <summary>
        /// The Id of the last Transaction created for the Account.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }

        /// <summary>
        /// The code of the error that has occurred. This field may not be returned
        /// for some errors.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// The human-readable description of the error that has occurred.
        /// </summary>
        [Required]
        public string ErrorMessage { get; set; }
    }


    public sealed class GetAccountChangesResponse : AccountRestv20EndpointResponse
    {
        /// <summary>
        /// The changes to the Account’s Orders, Trades and Positions since the
        /// specified Transaction Id. Only provIded if the sinceTransactionId is
        /// supplied to the poll request.
        /// </summary>
        public AccountChanges Changes { get; set; }

        /// <summary>
        /// The Account’s current price-dependent state.
        /// </summary>
        public AccountChangesState State { get; set; }

        /// <summary>
        /// The Id of the last Transaction created for the Account. This Transaction
        /// Id should be used for future poll requests, as the client has already
        /// observed all changes up to and including it.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }
}
