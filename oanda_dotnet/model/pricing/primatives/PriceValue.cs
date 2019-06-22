using System;

namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// The string representation of a Price for an Instrument.
    /// </summary>
   [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct PriceValue
    {
        private decimal _priceValue;

        public PriceValue(string priceValue)
        {
            _priceValue = Convert.ToDecimal(priceValue);
        }


        public static implicit operator PriceValue(string priceValue) => new PriceValue(priceValue);
        public static implicit operator string(PriceValue priceValue) => priceValue._priceValue.ToString();
    }
}
