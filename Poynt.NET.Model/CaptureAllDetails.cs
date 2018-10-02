
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CaptureAllDetails
    {

        private const string TAG = "CaptureAllDetails";
        public bool CloseBatch { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IList<string> CaptureSuccessfulAuthorizations { get; set; }
        public IList<string> CaptureFailAuthorizations { get; set; }
        public IList<string> CaptureProcessingAuthorizations { get; set; }

        public string CaptureAllRequestId { get; set; }

        public string BusinessId { get; set; }

        public string StoreId { get; set; }
        public string StoreDeviceId { get; set; }
        public string SettlementTid { get; set; }
        public string BatchId { get; set; }
        public string Status { get; set; }
        public string ProcessorStatusCode { get; set; }
        public string ProcessorStatusMessage { get; set; }
    }
}
