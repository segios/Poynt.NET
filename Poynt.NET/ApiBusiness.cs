using Poynt.NET.Endpoints;
using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiBusiness : Api<Business, BusinessList>
    {
        public ApiBusiness(PoyntSDK sdk, params string[] parents) : base(sdk, parents)
        {
        }

        public async Task<Business> GetByDeviceId(string deviceId)
        {
            return await Get(null, new FilterModel()
            {
                Filters = new Dictionary<string, string>() {
                    { "storeDeviceId", deviceId }
                }
            });
            
        }
    }
}
