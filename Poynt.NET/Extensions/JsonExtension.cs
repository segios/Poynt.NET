using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Extensions
{
    public static class JsonExtension
    {
        public static string ToJson(this object obj)
        {
            var jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonSerializerSettings.Converters.Add(new StringEnumConverter());
            jsonSerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;

            return JsonConvert.SerializeObject(obj, jsonSerializerSettings);
        }

        public static T FromJson<T>(this string json)
        {
            var jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonSerializerSettings.Converters.Add(new StringEnumConverter());
            jsonSerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;

            return JsonConvert.DeserializeObject<T>(json, jsonSerializerSettings);
        }
    }
}
