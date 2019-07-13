using System;

namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// The string representation of a Price for an Instrument.
    /// </summary>
   [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct PriceValue
    {
        public decimal _priceValue { get; set; }

        public PriceValue(string priceValue)
        {
            _priceValue = Convert.ToDecimal(priceValue);
        }

        public PriceValue(decimal priceValue) => _priceValue = priceValue;

        public static implicit operator PriceValue(string priceValue) => new PriceValue(priceValue);
        public static implicit operator PriceValue(decimal priceValue) => new PriceValue(priceValue);
        public static implicit operator string(PriceValue priceValue) => priceValue._priceValue.ToString();
        public static implicit operator decimal(PriceValue priceValue) => priceValue._priceValue;
    }
}
