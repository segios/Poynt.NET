using System;

namespace Poynt.NET.Model
{

    public class DiscoveredEndpoint

    {

        private const string TAG = "DiscoveredEndpoint";

        public int? HttpConnectTimeout { get; set; }

        public int? HttpReadTimeout { get; set; }

        public string Address { get; set; }

    }
}
