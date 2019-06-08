namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A client-provided comment that can contain any data and may be assigned to their Orders or Trades. 
    /// Comments are typically used to provide extra context or meaning to an Order or Trade.
    /// </summary>
    public class ClientComment
    {
        private string Comment { get; set; }

        public static implicit operator ClientComment(string comment) => new ClientComment() { Comment = comment };
        public static implicit operator string(ClientComment clientComment) => clientComment.Comment;
    }
}
