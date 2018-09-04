using System;

namespace Poynt.NET.Model
{

    public class DebitEBTReEntry

    {

        private const string TAG = "DebitEBTReEntry";

        public DateTime OrigCreatedAt { get; set; }

        public string OrigNetworkId { get; set; }

        public string OrigTraceNumber { get; set; }

        public string OrigRetrievalRefNumber { get; set; }

        public string OrigApprovalCode { get; set; }

    }
}
