using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{

    public class ClientConfig
    {
        public string Name { get; set; }
        public string AppId { get; set; }
        public string KeyFile { get; set; }
        public bool IsActive { get; set; }
        public string Secret { get; set; }

        [JsonIgnore]
        public string KeyFilePath { get; set; }
        [JsonIgnore]
        public string KeyFileData { get; set; }
    }
}
