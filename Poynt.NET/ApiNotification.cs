using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiNotification : Api<CloudMessage, List<CloudMessage>>
    {
        public ApiNotification(PoyntSDK sdk) : base(sdk, Constants.POYNT_API_HOST + Constants.API_CLOUD_MESSAGES)
        {

        }

        public async Task<CloudMessage> Send(CloudMessage msg)
        {
            return await Create(msg);
        }

    }
}
