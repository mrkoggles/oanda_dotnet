using System;

namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// The string representation of a Price for an Instrument.
    /// </summary>
    public struct PriceValue
    {
        private decimal _priceValue;

        public static implicit operator PriceValue(string priceValue) => new PriceValue { _priceValue = Convert.ToDecimal(priceValue) };
        public static implicit operator string(PriceValue priceValue) => priceValue._priceValue.ToString();
    }
}
