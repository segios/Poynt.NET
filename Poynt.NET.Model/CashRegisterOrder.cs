
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CashRegisterOrder

    {

        private const string TAG = "CashRegisterOrder";

        public int? Change { get; set; }

        public int? Subtotal { get; set; }

        public int? Tax { get; set; }

        public int? TenderAmount { get; set; }

        public IList<CashRegisterOrderItem> Items { get; set; }

        public string BusinessId { get; set; }

        public string CheckoutCmd { get; set; }

        public string Currency { get; set; }

        public string OrderNumber { get; set; }

        public string TenderType { get; set; }

    }
}
