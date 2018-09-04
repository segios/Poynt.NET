using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DiscoveryEndpoint

    {

        private const string TAG = "DiscoveryEndpoint";

        public IDictionary<string, string> Parameters;

        public string Address { get; set; }

        public string Version { get; set; }

    }
}
