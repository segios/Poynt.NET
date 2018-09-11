using Newtonsoft.Json;
using Poynt.NET.Exceptions;
using Poynt.NET.Extensions;
using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class PoyntSDK
    {
        protected static Dictionary<Type, Type> apiContainer = new Dictionary<Type, Type>();

        private Config config;
        private ClientConfig clientConfig;
        private ConfigRoot configRoot;
        private JsonWebToken JsonWebToken;
        private string accessToken;
        private string refreshToken;

        static PoyntSDK()
        {
            Type apiType = typeof(Api<,>);
            var apis = from x in apiType.Assembly.GetTypes()
                       let y = x.BaseType
                       where !x.IsAbstract && !x.IsInterface &&
                       y != null && y.IsGenericType &&
                       y.GetGenericTypeDefinition() == apiType
                       select x;

            foreach (var api in apis)
            {
                apiContainer.Add(api, api);
            }
        }


        public PoyntSDK(ConfigRoot configRoot, ClientConfig clientConfig, Config config = null)
        {
            this.config = config ?? new Config();
            this.configRoot = configRoot;
            this.clientConfig = clientConfig;
            JsonWebToken = new JsonWebToken(this.config, this.clientConfig);
        }

        public PoyntSDK(ConfigRoot configRoot, string clientConfigName, Config config = null)
            : this(configRoot, configRoot.GetClientConfig(clientConfigName), config)
        {
        }


        public virtual T Api<T>()
        {
            var type = typeof(T);
            if (!apiContainer.ContainsKey(type))
            {
                return default(T);
            }

            return (T)Activator.CreateInstance(type, this);
        }

        public ConfigRoot ConfigRoot
        {
            get
            {
                return configRoot;
            }
        }
        public ClientConfig ClientConfig
        {
            get
            {
                return clientConfig;
            }
        }

        public string AccessToken
        {
            get
            {
                if (string.IsNullOrEmpty(accessToken))
                {
                    GetAccessToken();
                }
                return accessToken;
            }
        }

        protected virtual string GetAccessToken()
        {
            try
            {
                var token = JsonWebToken.GetEncodedJwtToken();

                using (var httpClient = new HttpClient())
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, Constants.POYNT_API_HOST + Constants.API_TOKEN);
                    requestMessage.SetCommonApiHeaders(clientConfig);
                    string requestId = Guid.NewGuid().ToString();
                    //Logger.debug()
                    requestMessage.Headers.Add("Poynt-Request-Id", requestId);

                    Dictionary<string, string> nvc = new Dictionary<string, string>();

                    if (string.IsNullOrEmpty(refreshToken))
                    {
                        nvc.Add("grantType", "urn:ietf:params:oauth:grant-type:jwt-bearer");
                        nvc.Add("assertion", token);
                    }
                    else
                    {
                        nvc.Add("grantType", "REFRESH_TOKEN");
                        nvc.Add("refreshToken", this.refreshToken);
                    }

                    var content = new FormUrlEncodedContent(nvc);
                    requestMessage.Content = content;

                    var response = httpClient.SendAsync(requestMessage).Result;

                    var contentResponse = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(contentResponse);
                        accessToken = tokenResponse.AccessToken;
                        refreshToken = tokenResponse.RefreshToken;

                        return accessToken;
                    }
                    else
                    {
                        var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(contentResponse);
                        // todo log error 
                        throw new PoyntSDKException("Error getting access token: " + errorResponse.DeveloperMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new PoyntSDKException("Error getting access token", ex);
            }
        }

        public void ClearAccessToken()
        {
            this.accessToken = null;
        }

        public void ClearRefreshToken()
        {
            this.accessToken = null;
            this.refreshToken = null;
        }



    }
}
