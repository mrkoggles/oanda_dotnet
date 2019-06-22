namespace oanda_dotnet.model.trade
{
    /// <summary>
    /// The identification of a Trade as referred to by clients
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct TradeSpecifier
    {
        /// <summary>
        /// Either the Trade’s OANDA-assigned TradeID or the Trade’s client-provided ClientID prefixed by the “@” symbol
        /// </summary>
        private string _tradeSpecifier;

        public static implicit operator TradeSpecifier(string tradeId) => new TradeSpecifier() { _tradeSpecifier = tradeId.Replace("@", string.Empty) };
        public static implicit operator string(TradeSpecifier tradeId) => $"@{tradeId._tradeSpecifier}";
    }
}
