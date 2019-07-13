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


        [Obsolete("Needs error handling")]
        public OrderId(string orderId)
        {
            if (uint.TryParse(orderId, out uint result)) { _orderId = result; }
            else { throw new Exception(); }
        }

        public OrderId(uint orderId)
        {
            _orderId = orderId;
        }


        public static implicit operator uint(OrderId orderId) => orderId._orderId;
        public static implicit operator string (OrderId orderId) => orderId._orderId.ToString();
        public static implicit operator OrderId(uint orderId) => new OrderId { _orderId = orderId };
        public static implicit operator OrderId(string orderId) => new OrderId(orderId);
    }
}
