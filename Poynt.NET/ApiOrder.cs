using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiOrder : Api<Order, OrderList>
    {
        public ApiOrder(PoyntSDK sdk) : base(sdk, Constants.POYNT_API_HOST + Constants.API_ORDERS)
        {

        }

    }
}
