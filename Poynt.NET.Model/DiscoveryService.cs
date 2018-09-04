using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DiscoveryService

    {

        private const string TAG = "DiscoveryService";

        public DiscoveryEndpoint EndPoint { get; set; }

        public IDictionary<string, string> Parameters { get; set; }

        public string Name { get; set; }

    }
}
