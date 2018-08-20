using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Extensions
{
    public static class HttpRequestMessageExtensions
    {
        public static void SetCommonApiHeaders(this HttpRequestMessage requestMessage, ClientConfig clientConfig)
        {
            requestMessage.Headers.Add("User-Agent", Constants.SDK_AGENT + " " + clientConfig.AppId.Replace(":", "_"));
            requestMessage.Headers.Add("api-version", Config.POYNT_API_VERSION);

        }
    }
}
