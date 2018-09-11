using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiCatalog : Api<Catalog, CatalogList>
    {
        public ApiCatalog(PoyntSDK sdk) : base(sdk, Constants.POYNT_API_HOST + Constants.API_CATALOGS)
        {

        }
        public async Task<CatalogWithProduct> Get(string businessId, string catalogId)
        {
            return await GetFromBusiness<CatalogWithProduct>(businessId, catalogId);
        }

    }
}
