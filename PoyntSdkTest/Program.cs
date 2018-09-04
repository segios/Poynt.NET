using Newtonsoft.Json;
using Poynt.NET;
using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PoyntSdkTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\Poynt.NET.Config");

            var provider = new ClientConfigProvider(path);
            var configRoot = provider.ConfigRoot;
            try
            {
                var sdk = new PoyntSDK(configRoot, "test");

                var business = await GetBusiness(sdk, "6a9a297c-ec88-4313-b8f6-2fd8da88e57a");
                PrintObject(business);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }

        private static void PrintObject(object obj)
        {
            var res = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Console.WriteLine(res);
        }

        private static async Task<Business> GetBusiness(PoyntSDK sdk, string id)
        {
            var apiBussiness = sdk.Business();
            var result = await apiBussiness.Get(id);

            return result;
        }

        private static void PrintHooks(ConfigRoot configRoot)
        {
            var sdk = new PoyntSDK(configRoot, "test");

            var webhook = sdk.Webhook();

            var allHooks = webhook.GetAllFromBusiness(configRoot.BusinessId).Result;
            var activeHooks = allHooks.Hooks.Where(x => x.Active == true).ToList();
            activeHooks.ForEach(x =>
            {
                Console.WriteLine("--start hook--");
                var kvApp = configRoot.ClientConfigs.FirstOrDefault(r => r.Value.AppId == x.ApplicationId);

                Console.WriteLine(string.Format("App: {0}", kvApp.Key));
                Console.WriteLine(string.Format("AppId: {0}", x.ApplicationId));
                Console.WriteLine(string.Format("HookId: {0}", x.Id));
                Console.WriteLine(string.Format("Url: {0}", x.DeliveryUrl));

                Console.WriteLine("--end hook--\r\n");
            });

            if (!activeHooks.Any())
            {
                Console.WriteLine("No Active hooks found\r\n");
            }
        }


    }
}
