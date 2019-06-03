using oanda_dotnet.client;
using oanda_dotnet.model.pricing;
using oanda_dotnet.model;
using System.Collections.Generic;
using System;

namespace oanda_dotnet.api
{
    public sealed class PricingApi : Restv20Api
    {
        public PricingApi(Restv20Client client) : base(client) { }

        private static ICollection<T> GenerateCollection<T>(T t)
            where T: new()
        {
            return new List<T>() { t };
        }
    }
}
