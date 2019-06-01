using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace oanda_dotnet.model
{
    public abstract class Restv20Request
    {
        public abstract string Endpoint { get; }

        public bool IsValid()
        {
            return true;
        }

        public IRestRequest GenerateRestRequest()
        {
            return new RestRequest();
        }
    }
}
