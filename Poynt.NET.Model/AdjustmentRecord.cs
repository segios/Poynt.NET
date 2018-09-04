
using System;

namespace Poynt.NET.Model
{

    public class AdjustmentRecord

    {

        private const string TAG = "AdjustmentRecord";

        public bool? SignatureCaptured { get; set; }

        public DateTime CreatedAt { get; set; }

        public ExchangeRate ExchangeRate { get; set; }

        public int? Sequence { get; set; }

        public ProcessorResponse ProcessorResponse { get; set; }

        public TransactionAmounts Amounts { get; set; }

        public TransactionAmounts AmountChanges { get; set; }

        public TransactionReason Reason { get; set; }

        public sbyte[] signature { get; set; }

    }
}
