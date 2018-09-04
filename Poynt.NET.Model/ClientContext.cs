
using System;

namespace Poynt.NET.Model
{
    public class ClientContext

    {

        private const string TAG = "ClientContext";

        public BusinessType BusinessType { get; set; }

        public DateTime TransmissionAtLocal { get; set; }

        public long? EmployeeUserId { get; set; }

        public string StoreDeviceId { get; set; }

        public string SourceApp { get; set; }

        public string Mid { get; set; }

        public string Tid { get; set; }

        public string Mcc { get; set; }

        public string StoreAddressTerritory { get; set; }

        public string StoreAddressCity { get; set; }

        public string StoreTimezone { get; set; }

        public TransactionInstruction TransactionInstruction { get; set; }

        public TransactionSource Source { get; set; } = TransactionSource.INSTORE;

        public System.Guid businessId { get; set; }

        public System.Guid storeId { get; set; }
    }
}
