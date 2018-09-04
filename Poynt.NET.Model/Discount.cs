
using System;

namespace Poynt.NET.Model
{

    public class Discount

    {

        private const string TAG = "Discount";

        public float? Percentage { get; set; }

        public long? Amount { get; set; }

        public ProcessorResponse ProcessorResponse { get; set; }

        public string CustomName { get; set; }

        public string Id { get; set; }

        public string Provider { get; set; }

        public string Processor { get; set; }

    }
}
