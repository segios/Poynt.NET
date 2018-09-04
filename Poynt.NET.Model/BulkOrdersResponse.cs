using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class BulkOrdersResponse

    {

        private const string TAG = "BulkOrdersResponse";

        public IList<System.Guid> OrdersCreated { get; set; }

        public long? NumCreated { get; set; }

    }
}
