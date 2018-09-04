using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class CustomerList

    {

        private const string TAG = "CustomerList";

        public IList<Customer> Customers { get; set; }

        public IList<Link> Links { get; set; }

        public long? Count { get; set; }

    }
}
