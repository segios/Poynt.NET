
using System;

namespace Poynt.NET.Model
{
    public class CustomFundingSource
    {

        private const string TAG = "CustomFundingSource";

        public CustomFundingSourceType Type { get; set; }

        public string Name { get; set; }

        public string Provider { get; set; }

        public string Processor { get; set; }

        public string AccountId { get; set; }

        public string Description { get; set; }
    }
}
