using System;

namespace oanda_dotnet.model
{
    [Obsolete("Needs development")]
    public interface IOandaDateTime
    {
        System.DateTime DateTime { get; }
    }


   ///[Newtonsoft.Json.JsonConverter(typeof(oanda_dotnet.serialization.ImplicitOperatorConverter))]
   [Obsolete("Shouldn't be used")]
    public struct UnixDateTime : IOandaDateTime
    {
        public System.DateTime DateTime { get; private set; }

        public UnixDateTime(System.DateTime dateTime) => DateTime = dateTime;
        public UnixDateTime(string dateTime) { DateTime = ((UnixDateTime)dateTime).DateTime; }

        public override string ToString()
        {
            return (new DateTimeOffset(this.DateTime).ToUnixTimeMilliseconds() / 1000M).ToString();
        }

        public static implicit operator string(UnixDateTime unixDateTime) => unixDateTime.ToString();
        public static implicit operator UnixDateTime(string dateTime)
        {
            return new UnixDateTime
            (
                DateTimeOffset.FromUnixTimeMilliseconds((long)(Convert.ToDecimal(dateTime) * 1000M)).Date
            );
        }
        public static implicit operator System.DateTime(UnixDateTime unixDateTime) => unixDateTime.DateTime;
    }

    public struct RFC3339DateTime : IOandaDateTime
    {
        public System.DateTime DateTime => throw new NotImplementedException();
    }
}
