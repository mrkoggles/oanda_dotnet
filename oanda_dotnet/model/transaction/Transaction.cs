using oanda_dotnet.model.account;
using System;
using Newtonsoft.Json.Converters;

namespace oanda_dotnet.model.transaction
{
    public interface ITransaction
    {
        TransactionId Id { get; set; }
        DateTime Time { get; set; }
        int UserId { get; set; }
        AccountId AccountId { get; set; }
        TransactionId BatchId { get; set; }
        RequestId RequestId { get; set; }
        TransactionType Type { get; }
    }


    /// <summary>
    /// The base Transaction specification. Specifies properties that are common between all Transaction.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.TransactionConverter))]
    public abstract class Transaction : ITransaction
    {
        public abstract TransactionType Type { get; }

        /// <summary>
        /// The Transaction’s Identifier.
        /// </summary>
        public TransactionId Id { get; set; }

        /// <summary>
        /// The date/time when the Transaction was created.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// The Id of the user that initiated the creation of the Transaction.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the Account the Transaction was created for.
        /// </summary>
        public AccountId AccountId { get; set; }

        /// <summary>
        /// The Id of the “batch” that the Transaction belongs to. Transactions in
        /// the same batch are applied to the Account simultaneously.
        /// </summary>
        public TransactionId BatchId { get; set; }

        /// <summary>
        /// The Request Id of the request which generated the transaction.
        /// </summary>
        public RequestId RequestId { get; set; }
    }
}
