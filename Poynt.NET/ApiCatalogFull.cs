using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    //businesses/{businessId}/catalogs/{catalogId}/full
    public class ApiCatalogFull : Api<CatalogWithProduct, List<CatalogList>>
    {
        public ApiCatalogFull(PoyntSDK sdk, params string[] parents) : base(sdk, parents)
        {

        }

        
    }

}
