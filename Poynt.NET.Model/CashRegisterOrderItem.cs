
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CashRegisterOrderItem

    {

        private const string TAG = "CashRegisterOrderItem";

        public int? Amount { get; set; }

        public int? Price { get; set; }

        public int? Quantity { get; set; }

        public int? RunningSubtotal { get; set; }

        public int? ItemTypeCount { get; set; }

        public int? Tax { get; set; }

        public IList<CashRegisterOrderItemContains> Contains { get; set; }

        public IList<string> WikipediaTagsList { get; set; }

        public string Category { get; set; }

        public string Cmd { get; set; }

        public string ItemCategory { get; set; }

        public string ItemClean { get; set; }

        public string ItemType { get; set; }

        public string Msg { get; set; }

        public string Name { get; set; }

        public string RegisterItemLong { get; set; }

    }
}
