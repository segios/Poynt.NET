using System;

namespace Poynt.NET.Model
{

    public class CaptureAllRange

    {

        private const string TAG = "CaptureAllRange";

        public CaptureAllRangeType Type { get; set; }

        public long? StartTimeSec { get; set; }

        public long? EndTimeSec { get; set; }

        public System.Guid firstTransactionId { get; set; }

        public System.Guid lastTransactionId { get; set; }

    }
}
