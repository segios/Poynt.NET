
using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CustomerInsights

    {

        private const string TAG = "CustomerInsights";

        public DateTime Since { get; set; }

        public IList<CurrencyAmount> LifetimeSpend { get; set; }

        public IList<CustomerScore> Scores { get; set; }

        public IList<CustomerTopItem> TopItems { get; set; }

        public long? TotalOrders { get; set; }

        public PoyntLoyalty PoyntLoyalty { get; set; }

    }
}
