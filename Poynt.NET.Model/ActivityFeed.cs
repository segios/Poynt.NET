
using System;

namespace Poynt.NET.Model
{

    public class ActivityFeed

    {

        private const string TAG = "ActivityFeed";

        public ActivityAction Action { get; set; }

        public ActivitySource Source { get; set; }

        public ActivityUser ActivityUser { get; set; }

        public decimal Rating { get; set; }

        public bool? NewMacAddress { get; set; }

        public DateTime ActionAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public long? Id { get; set; }

        public NetworkInterfaceType NetworkInterface { get; set; }

        public string SensorId { get; set; }

        public string ExternalId { get; set; }

        public string Text { get; set; }

        public string ImageUrl { get; set; }

        public TextSentiment Sentiment { get; set; }

        public System.Guid businessId { get; set; }

        public System.Guid storeId { get; set; }

    }
}
