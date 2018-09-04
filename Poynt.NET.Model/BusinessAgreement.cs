using System;

namespace Poynt.NET.Model
{

    public class BusinessAgreement

    {

        private const string TAG = "BusinessAgreement";

        public bool? VersionOutdated { get; set; }

        public bool? Current { get; set; }

        public BusinessAgreementType Type { get; set; }

        public DateTime AcceptedAt { get; set; }

        public long? UserId { get; set; }

        public string Version { get; set; }

    }
}
