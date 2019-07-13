using oanda_dotnet.model.transaction;

namespace oanda_dotnet.model
{
    public class Restv20EndpointResponse
    {
        public TransactionId LastTransactionId { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
