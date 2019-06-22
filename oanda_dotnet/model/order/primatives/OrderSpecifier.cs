namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The specification of an Order as referred to by clients
    /// </summary>
   [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct OrderSpecifier
    {
        /// <summary>
        /// Either the Order’s OANDA-assigned OrderID or the Order’s client-provided ClientID prefixed by the “@” symbol
        /// </summary>
        private string _orderSpecifier;

        public OrderSpecifier(string orderSpecifier)
        {
            _orderSpecifier = orderSpecifier.Replace("@", string.Empty);
        }


        public static implicit operator string(OrderSpecifier orderSpecifier) => $"@{orderSpecifier._orderSpecifier}";
        public static implicit operator OrderSpecifier(string orderSpecifier) => new OrderSpecifier(orderSpecifier);
    }
}
