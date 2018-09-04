using System;

namespace Poynt.NET.Model
{

    public class CustomerBusinessPreferences

    {

        private const string TAG = "CustomerBusinessPreferences";

        public bool? UseCardOnFile { get; set; }

        public bool? EmailReceipt { get; set; }

        public bool? PrintPaperReceipt { get; set; }

        public long? PreferredCardId { get; set; }
    }
}
