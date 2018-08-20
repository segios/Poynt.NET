using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poynt.NET.Exceptions;

namespace Poynt.NET
{
    public class ClientConfigProvider
    {
        protected const string ConfigDir = "poynt.configuration\\";
        protected const string ConfigFile = "poyntClientSDKConfig.json";
        private string basePath;
        private ConfigRoot configRoot;
        public ClientConfigProvider(string basePath)
        {
            this.basePath = basePath;
            ReadConfigs();
        }

        public  ConfigRoot ConfigRoot { get{ return configRoot; } }
        private void ReadConfigs()
        {
            var fileName = Path.Combine(basePath, ConfigDir, ConfigFile);
            if (!File.Exists(fileName))
            {
                throw new PoyntSDKException(string.Format("Client config file '{0}' not found", fileName));
            }

            var configData = File.ReadAllText(fileName);
            configRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigRoot>(configData);
            foreach (var key in configRoot.ClientConfigs.Keys)
            {
                var clientConfig = configRoot.ClientConfigs[key];
                if (!string.IsNullOrEmpty(clientConfig.KeyFile)) {
                    var filePath = Path.Combine(basePath, ConfigDir, clientConfig.KeyFile);
                    if (!File.Exists(filePath))
                    {
                        throw new PoyntSDKException(string.Format("Key File '{0}' not found", filePath));
                    }
                    clientConfig.KeyFilePath = filePath;

                    var pemFileData = File.ReadAllText(filePath);
                    clientConfig.KeyFileData = pemFileData;
                }
            }
        }

    }
}
