
using System;

namespace Poynt.NET.Model
{

    public class CloudMessage

    {

        private const string TAG = "CloudMessage";

        public ComponentName Recipient { get; set; }

        public int? Ttl { get; set; }

        public string Id { get; set; }

        public string CollapseKey { get; set; }

        public string Data { get; set; }

        public string DeviceId { get; set; }

        public string SerialNum { get; set; }

        public string Sender { get; set; }

        public System.Guid businessId { get; set; }

        public System.Guid storeId { get; set; }

    }
}
