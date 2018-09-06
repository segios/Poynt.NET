using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{

    /*
     businessId path  string (required)
    If-Modified-Since header string (optional)
    startAt query string (optional)
    startOffset query integer (optional)
    endAt query string (optional)
    limit query integer (optional)
    storeId query  string (optional)
    deviceId query string (optional)
    searchKey query string (optional)
    cardNumberFirst6 query string (optional)
    cardNumberLast4 query string (optional)
    cardExpirationMonth query integer (optional)
    cardExpirationYear query integer (optional)
    cardHolderFirstName query string (optional)
    cardHolderLastName query string (optional)
    action query string (optional)
    status query string (optional)
    transactionIds query array (optional)
    authOnly query  boolean (optional)
    unsettledOnly query boolean (optional)
    creditDebitOnly query boolean (optional)

             */
    public class TransactionFilterModel : FilterModel
    {
        public string storeId { get; set; }
        public string deviceId { get; set; }
        public string searchKey { get; set; }
        public string action { get; set; }
        public string cardNumberFirst6 { get; set; }
        public string cardNumberLast4 { get; set; }
        public int? cardExpirationMonth { get; set; }
        public int? cardExpirationYear { get; set; }
        public string cardHolderFirstName { get; set; }
        public string cardHolderLastName { get; set; }
        public string status { get; set; }
        public string[] transactionIds { get; set; }
        public bool? authOnly { get; set; }
        public bool? unsettledOnly { get; set; }
        public bool? creditDebitOnly { get; set; }
    }

}
