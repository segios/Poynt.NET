
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class BulkOrdersRequest

    {

        private const string TAG = "BulkOrdersRequest";

        public int? OrderCountPerTimeWindow { get; set; }

        public int? TimeWindowInSec { get; set; }

        public int? CashOrdersPercent { get; set; }

        public IList<Card> Cards { get; set; }

        public long? StartTimeSec { get; set; }

        public long? EndTimeSec { get; set; }

        public long? EmployeeUserId { get; set; }

        public string StoreDeviceId { get; set; }

        public TransactionAction CardTxnsAction { get; set; }

        public System.Guid storeId { get; set; }

    }
}
