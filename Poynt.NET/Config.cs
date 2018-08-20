using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class Config
    {

        //public const string PROP_API_SOCKET_TIMEOUT = "httpSocketTimeout";
        //public const string PROP_API_CONNECT_TIMEOUT = "httpConnectTimeout";
        //public const string PROP_API_REQUEST_TIMEOUT = "httpRequestTimeout";
        //public const string PROP_API_MAX_CONNECTION = "httpMaxConnection";
        //public const string PROP_API_MAX_CONN_PER_ROUTE = "httpMaxConnectionPerRoute";

        public const string POYNT_API_VERSION = "1.2";
        public const string POYNT_API_HOST = "https://services.poynt.net";

        public string ApiVersion { get; set; } = POYNT_API_VERSION;
        public string ApiHost { get; set; } = POYNT_API_HOST;
    }
}
