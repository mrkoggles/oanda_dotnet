namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A client-provided identifier, used by clients to refer to their Orders or Trades with an identifier that they have provided.
    /// </summary>
    public class ClientId
    {
        private string _clientId;

        public static implicit operator ClientId(string clientId) => new ClientId() { _clientId = clientId };
        public static implicit operator string(ClientId clientId) => clientId._clientId;
    }
}
