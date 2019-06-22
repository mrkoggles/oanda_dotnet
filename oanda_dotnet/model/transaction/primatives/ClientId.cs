namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A client-provided identifier, used by clients to refer to their Orders or Trades with an identifier that they have provided.
    /// </summary>
   [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct ClientId
    {
        private string _clientId;
        
        public ClientId(string clientId) => _clientId = clientId;

        public static implicit operator ClientId(string clientId) => new ClientId(clientId);
        public static implicit operator string(ClientId clientId) => clientId._clientId;
    }
}
