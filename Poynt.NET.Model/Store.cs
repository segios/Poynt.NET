//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class Store

    {

        private const string TAG = "Store";

        public Address Address { get; set; }

        public bool? FixedLocation { get; set; }

        public bool? MockProcessor { get; set; }

        public float? Longitude { get; set; }

        public float? Latitude { get; set; }

        public IList<StoreDevice> StoreDevices { get; set; }

        public IList<StoreTerminalId> StoreTerminalIds { get; set; }

        public long? _id { get; set; }

        public IDictionary<string, string> Attributes { get; set; }

        public IDictionary<string, string> ProcessorData { get; set; }

        public Phone Phone { get; set; }

        public Processor Acquirer { get; set; }

        public Processor Processor { get; set; }

        public StoreStatus Status { get; set; }

        public string ExternalStoreId { get; set; }

        public string GatewayStoreId { get; set; }

        public string DisplayName { get; set; }

        public string Currency { get; set; }

        public string Timezone { get; set; }

        public string CatalogId { get; set; }

        protected string ProcessorAdapterId { get; set; }

        public System.Guid id;

    }
}
