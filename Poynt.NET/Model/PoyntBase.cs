using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class PoyntBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}
