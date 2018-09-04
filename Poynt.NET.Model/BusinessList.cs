using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class BusinessList

    {

        private const string TAG = "BusinessList";

        public IList<Business> Businesses { get; set; }

        public IList<Link> Links { get; set; }

        public long? Count { get; set; }
    }
}
