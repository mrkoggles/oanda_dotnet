namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// The request identifier.
    /// </summary>
    public struct RequestId
    {
        private string _requestId;

        public static implicit operator string(RequestId requestId) => requestId._requestId;
        public static implicit operator RequestId(string requestId) => new RequestId { _requestId = requestId };
    }
}
