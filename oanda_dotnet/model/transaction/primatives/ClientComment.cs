namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A client-provided comment that can contain any data and may be assigned to their Orders or Trades. 
    /// Comments are typically used to provide extra context or meaning to an Order or Trade.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct ClientComment
    {
        private string _clientComment;

        public static implicit operator ClientComment(string comment) => new ClientComment() { _clientComment = comment };
        public static implicit operator string(ClientComment clientComment) => clientComment._clientComment;
    }
}
