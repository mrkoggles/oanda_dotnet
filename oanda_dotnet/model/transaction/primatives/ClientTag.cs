namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A client-provided identifier, used by clients to refer to their Orders or Trades with an identifier that they have provided.
    /// </summary>
    public class ClientTag
    {
        private string Tag { get; set; }

        public static implicit operator ClientTag(string clientTag) => new ClientTag() { Tag = ClientTag };
        public static implicit operator string(ClientTag clientTag) => clientTag.Tag;
    }
}
