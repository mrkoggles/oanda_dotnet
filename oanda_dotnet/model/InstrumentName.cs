using System;

namespace oanda_dotnet.model
{
    /// <summary>
    /// Instrument name identifier. Used by clients to refer to an Instrument.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
    public struct InstrumentName
    {
        public Currency BaseCurrency { get; set; }
        public Currency QuoteCurrency { get; set; }

        /// <summary>
        /// A string containing the base currency and quote currency delimited by a “_”.
        /// </summary>
        public static implicit operator InstrumentName(string instrumentName)
        {
            if (!instrumentName.Contains("_")) { throw new Exception(); }
            string[] currencies = instrumentName.Split('_');
            return new InstrumentName()
            {
                BaseCurrency = (Currency)Enum.Parse(typeof(Currency), currencies[0]),
                QuoteCurrency = (Currency)Enum.Parse(typeof(Currency), currencies[1])
            };
        }

        public static implicit operator string(InstrumentName instrumentName) => instrumentName.ToString();
        public override string ToString()
            => string.Format(@"{0}_{1}", this.BaseCurrency, this.QuoteCurrency);
    }
}
