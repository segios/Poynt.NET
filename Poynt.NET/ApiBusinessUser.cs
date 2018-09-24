using Poynt.NET.Endpoints;
using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiBusinessUser : Api<BusinessUser, List<BusinessUser>>
    {
        public ApiBusinessUser(PoyntSDK sdk, params string[] parents) : base(sdk, parents)
        {

        }

        //public async Task<BusinessUser> Get(int userId)
        //{
        //    return await GetFromBusiness<BusinessUser>(businessId, userId.ToString());
        //}
    }
}
