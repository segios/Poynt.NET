using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiVariant : Api<Variant, List<Variant>>
    {
        public ApiVariant(PoyntSDK sdk, params string[] parents) : base(sdk, parents)
        {

        }

      
    }
}
