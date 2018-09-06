using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{

//If-Modified-Since header - ISO8601 Time to filters result by item's last updated time.
//startAt query ISO8601 Time to filters result by a specific start time.
//startOffset query Integer offset from first item.
//endAt query ISO8601 Time to filters result by a specific end time.
//limit query Integer value 1 to 100 to limit the number of items returned.Default is 10.

    public class FilterModel
    {
        public DateTime? IfModifiedSince { get; set; }
        public DateTime? startAt { get; set; }
        public DateTime? endAt { get; set; }
        public int? startOffset { get; set; }
        public int? limit { get; set; }
        public Dictionary<string, string> Filters { get; set; } = new Dictionary<string, string>();
    }

}
