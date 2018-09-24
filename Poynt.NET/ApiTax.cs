using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiTax : Api<Tax, TaxList>
    {
        public ApiTax(PoyntSDK sdk, params string[] parents) : base(sdk, parents)
        {

        }

    }
}
