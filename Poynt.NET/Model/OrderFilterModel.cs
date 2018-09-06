using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{

//cardNumberFirst6 query string (optional)
//cardNumberLast4 query string (optional)
//cardExpirationMonth query integer(optional)
//cardExpirationYear query integer(optional)
//cardHolderFirstName query string (optional)
//cardHolderLastName query string (optional)
//storeId query string (optional)
//includeStaysAll query boolean(optional)

    public class OrderFilterModel : FilterModel
    {
        public string cardNumberFirst6 { get; set; }
        public string cardNumberLast4 { get; set; }
        public string cardExpirationMonth { get; set; }
        public string cardExpirationYear { get; set; }
        public string cardHolderFirstName { get; set; }
        public string storeId { get; set; }
        public bool? includeStaysAll { get; set; }
    }

}
