using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class Constants
    {
        public const string SDK_AGENT = "Poynt.NET SDK 1.0";

        //public const string PROP_API_SOCKET_TIMEOUT = "httpSocketTimeout";
        //public const string PROP_API_CONNECT_TIMEOUT = "httpConnectTimeout";
        //public const string PROP_API_REQUEST_TIMEOUT = "httpRequestTimeout";
        //public const string PROP_API_MAX_CONNECTION = "httpMaxConnection";
        //public const string PROP_API_MAX_CONN_PER_ROUTE = "httpMaxConnectionPerRoute";

        public const string POYNT_API_VERSION = "1.2";
        public const string POYNT_API_HOST = "https://services.poynt.net";
        public const string API_TOKEN = "/token";
        public const string API_BUSINESSES = "/businesses";
        public const string API_BUSINESS_USERS = "/businesses/{businessId}/businessUsers";
        public const string API_CATALOGS = "/businesses/{businessId}/catalogs";
        public const string API_PRODUCTS = "/businesses/{businessId}/products";
        public const string API_TRANSACTIONS = "/businesses/{businessId}/transactions";
        public const string API_ORDERS = "/businesses/{businessId}/orders";
        public const string API_CLOUD_MESSAGES = "/cloudMessages";
        public const string API_WEBHOOKS = "/hooks";

    }
}
