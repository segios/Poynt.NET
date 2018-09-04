
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class Delivery

    {

        private const string TAG = "Delivery";

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DeliveryStatus Status { get; set; }

        public int? Attempt { get; set; }

        public IList<Link> Links { get; set; }

        public string Id { get; set; }

        public string DeviceId { get; set; }

        public string DeliveryUrl { get; set; }

        public string HookId { get; set; }

        public string ApplicationId { get; set; }

        public string Resource { get; set; }

        public string ResourceId { get; set; }

        public string EventType { get; set; }

        public string Secret { get; set; }

        public System.Guid businessId { get; set; }

        public System.Guid storeId { get; set; }
    }
}
