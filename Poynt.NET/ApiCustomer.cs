using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiCustomer : Api<Customer, CustomerList>
    {
        public ApiCustomer(PoyntSDK sdk) : base(sdk, Constants.POYNT_API_HOST + Constants.API_CUSTOMERS)
        {

        }

    }
}
