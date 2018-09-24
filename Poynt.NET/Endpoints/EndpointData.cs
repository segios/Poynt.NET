using System;
using System.Collections.Generic;
using System.Text;

namespace Poynt.NET.Endpoints
{

    public class EndpointData : IEndpoint
    {
        public EndpointData(string endPoint , IEndpoint parentEndpoint = null)
        {
            Endpoint = endPoint;
            ParentEndpoint = parentEndpoint;
        }

        public virtual string Endpoint { get; set; }
        public IEndpoint ParentEndpoint { get; set; }

        public string Resolve(params string[] parents)
        {
            List<string> segments = new List<string>();
            segments.Add(Endpoint);
            var parent = ParentEndpoint;
            while (parent != null)
            {
                segments.Add(parent.Endpoint);
                parent = parent.ParentEndpoint;
            }

            segments.Reverse();
            var sb = new StringBuilder();
            for (var i = 0; i < segments.Count; i++)
            {
                if (i < parents.Length)
                {
                    sb.Append($"{segments[i]}/{parents[i]}");
                }
                else
                {
                    sb.Append($"{segments[i]}");
                }
            }

            return sb.ToString();
        }
    }
}
