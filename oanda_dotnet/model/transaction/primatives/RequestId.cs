namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The request identifier.
    /// </summary>
   [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct RequestId
    {
        private string _requestId;

        public RequestId(string requestId) => _requestId = requestId;

        public static implicit operator string(RequestId requestId) => requestId._requestId;
        public static implicit operator RequestId(string requestId) => new RequestId(requestId);
    }
}
