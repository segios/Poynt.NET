
using System;

namespace Poynt.NET.Model
{

    public class SessionKeysResponse
    {

        private const string TAG = "SessionKeysResponse";

        public DateTime AuthorizationAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        public Processor Acquirer { get; set; }
        public Processor Processor { get; set; }
        public string PinSessionKey { get; set; }

        public string MacSessionKey { get; set; }

        public string ReferenceNumber { get; set; }

        public string DebitResponseCode { get; set; }
    }
   
}
