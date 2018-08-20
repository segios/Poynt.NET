using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class Phone: PoyntBase
    {
        public string Status { get; set; } //enum['ADDED', 'ACTIVATED', 'LOCKED', 'CLOSED']
        public string Type { get; set; }
        public string ItuCountryCode { get; set; }
        public string AreaCode { get; set; }
        public string LocalPhoneNumber { get; set; }
        public string ExtensionNumber { get; set; }
    }
}
