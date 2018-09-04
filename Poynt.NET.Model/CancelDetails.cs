
using System;

namespace Poynt.NET.Model
{

    public class CancelDetails

    {

        private const string TAG = "CancelDetails";

        public ProcessorResponse CancelProcessorResponse { get; set; }

        public string StoreDeviceId { get; set; }

        public string DeveloperMessage { get; set; }

        public TransactionAction OriginalTransactionAction { get; set; }

        public TransactionStatus OriginalTransactionStatus { get; set; }

        public System.Guid originalTransactionId { get; set; }

        public System.Guid cancelTransactionId { get; set; }

        public System.Guid businessId { get; set; }

        public System.Guid storeId { get; set; }

    }
}
