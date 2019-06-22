using System;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The unique Transaction identifier within each Account.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct TransactionId
    {
        private ulong _transactionId;

        public static implicit operator ulong(TransactionId transactionId) => transactionId._transactionId;
        public static implicit operator string(TransactionId transactionId) => transactionId.ToString();

        public static implicit operator TransactionId(ulong transactionId) => new TransactionId { _transactionId = transactionId };

        [Obsolete("Needs error handling")]
        public static implicit operator TransactionId(string transactionId)
        {
            if (ulong.TryParse(transactionId, out ulong result)) { return new TransactionId { _transactionId = result }; }
            else { throw new Exception(); }
        }

        public override string ToString()
            => this._transactionId.ToString();
    }
}
