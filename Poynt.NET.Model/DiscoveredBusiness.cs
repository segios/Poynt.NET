using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DiscoveredBusiness

    {

        private const string TAG = "DiscoveredBusiness";

        public IDictionary<string, string> ChallengeQuestions { get; set; }

        public string ActivationToken { get; set; }

        public string BusinessName { get; set; }

        public string StoreName { get; set; }

        public string StoreAddress { get; set; }
    }
}
