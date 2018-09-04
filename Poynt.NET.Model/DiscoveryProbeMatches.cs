
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DiscoveryProbeMatches

    {

        private const string TAG = "DiscoveryProbeMatches";

        public bool? MockProcessor { get; set; }

        public DiscoveryClient Client { get; set; }

        public IDictionary<string, bool> ProcessorFeatureMap { get; set; }

        public IDictionary<string, DiscoveryService> Services { get; set; }

        public Processor Acquirer { get; set; }

        public Processor Processor { get; set; }
    }
}
