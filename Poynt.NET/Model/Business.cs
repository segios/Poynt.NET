using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class Business: PoyntBase
    {
        public string BusinessUrl { get; set; }
        public string IndustryType { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } //enum['ADDED', 'ACTIVATED', 'LOCKED', 'CLOSED']
        public DateTime ActiveSince { get; set; }
        public string SIC { get; set; }
        public dynamic ProcessorData { get; set; }
        public string Timezone { get; set; }
        public string Processor { get; set; }
        public string Acquirer { get; set; }
        public string MCC { get; set; }
        public string LegalName { get; set; }
        public string DoingBusinessAs { get; set; }
        public string EmailAddress { get; set; }
        public string ExternalMerchantId { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }
        public string Type { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
    }
}
