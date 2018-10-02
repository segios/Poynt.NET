
using System;

namespace Poynt.NET.Model
{

    public class SessionKeysRequest
    {

        private const string TAG = "SessionKeysRequest";

        public string Mid { get; set; }

        public string Tid { get; set; }

        public string SystemTraceAuditNumber { get; set; }
    }
   
}
