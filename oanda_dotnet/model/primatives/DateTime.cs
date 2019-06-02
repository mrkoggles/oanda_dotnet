using System;

namespace oanda_dotnet.model
{
    public struct UnixDateTime
    {
        private System.DateTime _dateTime;

        public UnixDateTime(System.DateTime dateTime) => _dateTime = dateTime;
        public UnixDateTime(string dateTime) { _dateTime = ((UnixDateTime)dateTime)._dateTime; }

        public override string ToString()
        {
            return (new DateTimeOffset(this._dateTime).ToUnixTimeMilliseconds() / 1000M).ToString();
        }

        public static implicit operator string(UnixDateTime unixDateTime) => unixDateTime.ToString();
        public static implicit operator UnixDateTime(string dateTime)
        {
            return new UnixDateTime
            (
                DateTimeOffset.FromUnixTimeMilliseconds((long)(Convert.ToDecimal(dateTime) * 1000M)).Date
            );
        }
        public static implicit operator System.DateTime(UnixDateTime unixDateTime) => unixDateTime._dateTime;
    }

    public struct RFC3339DateTime
    {

    }
}
