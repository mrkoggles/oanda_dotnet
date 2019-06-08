namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A client-provided identifier, used by clients to refer to their Orders or Trades with an identifier that they have provided.
    /// </summary>
    public class ClientId
    {
        private string Id { get; set; }

        public static implicit operator ClientId(string clientId) => new ClientId() { Id = clientId };
        public static implicit operator string(ClientId clientId) => clientId.Id;
    }
}
