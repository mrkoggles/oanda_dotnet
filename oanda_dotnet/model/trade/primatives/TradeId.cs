using System;

namespace oanda_dotnet.model.trade
{
    /// <summary>
    /// The Trade’s identifier, unique within the Trade’s Account.
    /// </summary>
    public class TradeId
    {
        private uint _tradeId;

        public static implicit operator uint(TradeId tradeId) => tradeId._tradeId;
        public static implicit operator string (TradeId tradeId) => tradeId._tradeId.ToString();

        public static implicit operator TradeId(uint tradeId) => new TradeId { _tradeId = tradeId };

        [Obsolete("Needs error handling")]
        public static implicit operator TradeId(string tradeId)
        {
            if (uint.TryParse(tradeId, out uint result)) { return new TradeId { _tradeId = result }; }
            else { throw new Exception(); }
        }
    }
}
