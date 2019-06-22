using System;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The Order’s identifier, unique within the Order’s Account.
    /// </summary>
    /// 
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct OrderId
    {
        private uint _orderId;

        public static implicit operator uint(OrderId orderId) => orderId._orderId;
        public static implicit operator string (OrderId orderId) => orderId._orderId.ToString();

        public static implicit operator OrderId(uint orderId) => new OrderId { _orderId = orderId };

        [Obsolete("Needs error handling")]
        public static implicit operator OrderId(string orderId)
        {
            if (uint.TryParse(orderId, out uint result)) { return new OrderId { _orderId = result }; }
            else { throw new Exception(); }
        }
    }
}
