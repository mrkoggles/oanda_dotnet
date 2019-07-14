using Newtonsoft.Json.Linq;
using System;

namespace oanda_dotnet.stream.model
{
    public abstract class Heartbeat
    {
        /// <summary>
        /// The string “HEARTBEAT”
        /// </summary>
        public string Type => "HEARTBEAT";

        /// <summary>
        /// The date/time when the Heartbeat was created.
        /// </summary>
        public DateTime? Time { get; set; }


        public static bool ResponseIsHeartBeat(string response)
            => JObject.Parse(response).GetValue("Type").ToString().ToLower() == "heartbeat";
    }
}
