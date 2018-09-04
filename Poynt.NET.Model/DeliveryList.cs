using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DeliveryList

    {

        private const string TAG = "DeliveryList";

        public IList<Delivery> Deliveries { get; set; }

        public IList<Link> Links { get; set; }

    }
}
