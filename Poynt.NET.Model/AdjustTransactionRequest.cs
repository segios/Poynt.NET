
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class AdjustTransactionRequest

    {

        private const string TAG = "AdjustTransactionRequest";

        public EMVData EmvData { get; set; }

        public IList<AdjustmentRecord> AdjustmentUpdates { get; set; }

        public Phone ReceiptPhone { get; set; }

        public string ReceiptEmailAddress { get; set; }

        public TransactionAmounts Amounts { get; set; }

        public TransactionReason Reason { get; set; }

        public sbyte[] signature { get; set; }

    }
}
