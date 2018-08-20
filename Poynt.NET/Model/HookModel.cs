using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class HookModel: PoyntBase
    {

        [JsonProperty("businessId")]
        public string BusinessId { get; set; }

        [JsonProperty("hookId")]
        public string HookId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }
}
