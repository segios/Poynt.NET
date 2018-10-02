
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DiscoveredActivation

    {

        private const string TAG = "DiscoveredActivation";

        public Address AtAddress { get; set; }

        public bool? MockProcessor { get; set; }

        public IDictionary<string, bool> PaymentFeatureMap { get; set; }

        public Processor Acquirer { get; set; }

        public Processor Processor { get; set; }

        public string BusinessName { get; set; }

        public string StoreName { get; set; }

        public string StoreAddress { get; set; }

        public string Mid { get; set; }

        public string Tid { get; set; }

        public System.Guid businessId { get; set; }

        public System.Guid storeId { get; set; }

        public System.Guid catalogId { get; set; }

    }
}
