namespace oanda_dotnet.model
{
    public enum AcceptDateTimeFormat
    {
        Unix,
        RFC3339
    }

    public struct InstrumentName
    {

    }

    public struct DateTime
    {

    }

    public class DecimalNumber
    {
        public static implicit operator DecimalNumber(string decimalNumber)
        {
            return new DecimalNumber();
        }

        public static implicit operator string(DecimalNumber decimalNumber)
        {
            return string.Empty;
        }
    }

}
