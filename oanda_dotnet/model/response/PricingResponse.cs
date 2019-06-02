using System.Collections.Generic;

namespace oanda_dotnet.model.pricing
{
    public class PricingResponse : Restv20Response
    {
        public ICollection<Price> Prices { get; set; }
        public ICollection<HomeConversions> HomeConversions { get; set; }
        public System.DateTime Time { get; set; }
    }
}
