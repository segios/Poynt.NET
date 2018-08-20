using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class Address: PoyntBase
    {
        public string Status { get; set; } //enum['ADDED', 'ACTIVATED', 'LOCKED', 'CLOSED']
        public string Type { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Territory { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string TerritoryType { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Line1);

            if (!string.IsNullOrEmpty(Line2)) {
                sb.AppendLine(Line2);
            }

            if (!string.IsNullOrEmpty(City))
            {
                sb.Append(City);
            }

            if (!string.IsNullOrEmpty(PostalCode))
            {
                sb.Append(" ");
                sb.Append(PostalCode);
            }


            if (!string.IsNullOrEmpty(Territory))
            {
                sb.Append(" ");
                sb.Append(Territory);
            }

            if (!string.IsNullOrEmpty(CountryCode))
            {
                sb.Append(" ");
                sb.Append(CountryCode);
            }
            return sb.ToString();
        }
    }
}
