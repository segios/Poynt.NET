using System;

namespace Poynt.NET.Model
{

    public class EBTDetails

    {

        private const string TAG = "EBTDetails";

        public EBTType Type { get; set; }

        public string ElectronicVoucherSerialNumber { get; set; }

        public string ElectronicVoucherApprovalCode { get; set; }

    }
}
