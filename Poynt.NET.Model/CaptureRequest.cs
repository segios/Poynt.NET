using System;

namespace Poynt.NET.Model
{

    public class CaptureRequest

    {

        private const string TAG = "CaptureRequest";

        public AdjustTransactionRequest AdjustTransaction { get; set; }

        public bool? CaptureOfflineAuth { get; set; }

        public string RequestId { get; set; }

        public System.Guid authTransactionId { get; set; }

    }
}
