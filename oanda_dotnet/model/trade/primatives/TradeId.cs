using System;

namespace oanda_dotnet.model.trade
{
    /// <summary>
    /// The Trade’s identifier, unique within the Trade’s Account.
    /// </summary>
   [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct TradeId
    {
        private uint _tradeId;

        [Obsolete("Needs error handling")]
        public TradeId(string tradeId)
        {
            if (uint.TryParse(tradeId, out uint result)) { _tradeId = result; } 
            else { throw new Exception(); }
        }

        public TradeId(uint tradeId) => _tradeId = tradeId;


        public static implicit operator uint(TradeId tradeId) => tradeId._tradeId;
        public static implicit operator string (TradeId tradeId) => tradeId._tradeId.ToString();
        public static implicit operator TradeId(uint tradeId) => new TradeId(tradeId);
        public static implicit operator TradeId(string tradeId) => new TradeId(tradeId);
    }
}
