using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Poynt.NET.Endpoints;
using Poynt.NET.Exceptions;
using Poynt.NET.Extensions;
using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class Api<TModel, TCollection> : ApiBase<TModel, TCollection>
        where TModel: class
        where TCollection : class
    {
        protected IEndpoint endPointRef;
        public Api(PoyntSDK sdk, params string[] parents): base(sdk, () => Constants.POYNT_API_HOST + EndpointConfig.Get<TModel>().Resolve(parents) )
        {
            this.endPointRef = EndpointConfig.Get<TModel>();
        }

        public async Task<TCollection> Lookup(IEnumerable<string> ids)
        {
            var idsQuery = string.Join(",", ids);
            string baseUrl = endPoint() + Constants.API_LOOKUP;
            var filter = new FilterModel()
            {
                Filters = new Dictionary<string, string>() {
                   { "ids", idsQuery }
                }
            };
            return await GetResource<TCollection>(baseUrl, filter);
        }

        //public async Task<TResult> GetFromBusiness<TResult>(string businessId, string path, FilterModel filter = null) where TResult : class
        //{
        //    string baseUrl = endPoint.Replace("{businessId}", businessId);
        //    if (!string.IsNullOrEmpty(path))
        //        baseUrl += path;

        //    return await GetResource<TResult>(baseUrl, filter);
        //}

        //public async Task<TCollection> GetAllFromBusiness(string businessId, FilterModel filter = null)
        //{
        //    const string businessIdTag = "businessId";

        //    string baseUrl = endPoint;
        //    if (baseUrl.Contains("{businessId}"))
        //    {
        //        baseUrl = endPoint.Replace("{businessId}", businessId);
        //    }
        //    else
        //    {
        //        if (filter == null)
        //        {
        //            filter = new FilterModel();
        //        }
        //        filter.Filters.Add(businessIdTag, businessId);
        //    }
        //    return await GetResource<TCollection>(baseUrl, filter);
        //}

        //public async Task<TModel> CreateAtBusiness(TModel resource, 
        //    string businessId)
        //{
        //    string baseUrl = endPoint.Replace("{businessId}", businessId);
        //    return await PostResource<TModel>(resource, baseUrl);
        //}

        //public async Task DeleteAtBusiness(string id, string businessId)
        //{
        //    string baseUrl = endPoint.Replace("{businessId}", businessId) + "/" + id;
        //    var res = await PostResource<TModel>(null, baseUrl, HttpMethods.Delete);
        //    return;
        //}

        //public async Task<TModel> UpdateAtBusiness(string id, string businessId, TModel patch)
        //{
        //    string baseUrl = endPoint.Replace("{businessId}", businessId) + "/" + id;
        //    var res = await PostResource<TModel>(patch, baseUrl, HttpMethods.PATCH);
        //    return res;
        //}
    }
}
