namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A client-provided identifier, used by clients to refer to their Orders or Trades with an identifier that they have provided.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct ClientTag
    {
        private string _clientTag;

        public static implicit operator ClientTag(string clientTag) => new ClientTag() { _clientTag = clientTag };
        public static implicit operator string(ClientTag clientTag) => clientTag._clientTag;
    }
}
