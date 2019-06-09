using System.Collections.Generic;

namespace oanda_dotnet.model.pricing
{
    public abstract class PricingRestv20EndpointResponse : Restv20EndpointResponse { }

    public sealed class GetPricingResponse : PricingRestv20EndpointResponse
    {
        public ICollection<Price> Prices { get; set; }
        public ICollection<HomeConversions> HomeConversions { get; set; }
        public System.DateTime Time { get; set; }
    }
}
