using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class ApplicationList

    {

        private const string TAG = "ApplicationList";

        public IList<Application> Applications { get; set; }

        public IList<Link> Links { get; set; }

        public long? Count { get; set; }

    }
}
