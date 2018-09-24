using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiWebhook : Api<Hook, HookList>
    {
        public ApiWebhook(PoyntSDK sdk, params string[] parents) : base(sdk, parents)
        {

        }

        public async Task<Hook> Register(Hook hook)
        {
            return await Create(hook);
        }
    }
}
