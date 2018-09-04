using System;

namespace Poynt.NET.Model
{

    public class DiscoveredPaymentService

    {

        private const string TAG = "DiscoveredPaymentService";

        public DiscoveredEndpoint EndPoint { get; set; }

        public int? SyncFrequency { get; set; }

    }
}
