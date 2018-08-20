using Newtonsoft.Json;
using Poynt.NET.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ConfigRoot
    {
        public string BusinessId { get; set; }
        public Dictionary<string, ClientConfig> ClientConfigs { get; set; }

        public ClientConfig GetClientConfigByAppId(string appId)
        {
            var clientConfig = ClientConfigs.FirstOrDefault(x => x.Value.AppId == appId);
            return clientConfig.Value;
        }

        public ClientConfig GetClientConfig(string name)
        {
            if (ClientConfigs == null)
            {
                throw new PoyntSDKException(string.Format("Client configs not initlized"));
            }

            if (ClientConfigs.ContainsKey(name))
            {
                return ClientConfigs[name];
            }

            throw new PoyntSDKException(string.Format("Client config '{0}' not found", name));
        }

    }

}
