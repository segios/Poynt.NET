using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class ActivateStoreDeviceRequest

    {

        private const string TAG = "ActivateStoreDeviceRequest";

        public Business Business { get; set; }

        public BusinessUser BusinessUser { get; set; }

        public IDictionary<string, string> ChallengeAnswers { get; set; }

        public Processor Acquirer { get; set; }

        public StoreDevice Device { get; set; }

        public string ExternalStoreId { get; set; }

        public string ActivationToken { get; set; }

    }
}
