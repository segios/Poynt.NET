using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
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
    public class ApiBase<TModel, TCollection> 
        where TModel: class
        where TCollection : class
    {
        protected PoyntSDK sdk;
        protected Func<string> endPoint;
        protected JsonSerializerSettings jsonSerializerSettings;
        protected Func<HttpClient> getHttpClient;
        public ApiBase(PoyntSDK sdk, string endPoint, Func<HttpClient> getHttpClient = null)
        {
            this.sdk = sdk;
            this.endPoint = () => endPoint;
            this.getHttpClient = getHttpClient ?? GetHttpClient;

            jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonSerializerSettings.Converters.Add(new StringEnumConverter());
            jsonSerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
        }

        public ApiBase(PoyntSDK sdk, Func<string> endPoint, Func<HttpClient> getHttpClient = null)
        {
            this.sdk = sdk;
            this.endPoint = endPoint;
            this.getHttpClient = getHttpClient ?? GetHttpClient;

            jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonSerializerSettings.Converters.Add(new StringEnumConverter());
            jsonSerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
        }

        protected virtual HttpClient GetHttpClient()
        {
            return new HttpClient();
        }


        protected virtual HttpRequestMessage CreateGetRequest(string url)
        {
            HttpRequestMessage get = new HttpRequestMessage(HttpMethod.Get, url);
            get.SetCommonApiHeaders(sdk.ClientConfig);
            return get;
        }

        protected virtual HttpRequestMessage CreatePostRequest(String url, HttpMethod method)
        {
            HttpRequestMessage post = new HttpRequestMessage(method, url);
            post.SetCommonApiHeaders(sdk.ClientConfig);

            return post;
        }

        protected virtual async Task HandleError(HttpResponseMessage response)
        {
            try
            {
                var errorResponse = await ReadResponse<ErrorResponse>(response)
                    .ConfigureAwait(false);

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    if (errorResponse.Code == Codes.INVALID_ACCESS_TOKEN)
                    {
                        sdk.ClearAccessToken();
                    }
                    else if (errorResponse.Code == Codes.INVALID_REFRESH_TOKEN)
                    {
                        sdk.ClearRefreshToken();
                    }
                }

                throw new PoyntSDKException(errorResponse.DeveloperMessage)
                {
                    Code = errorResponse.Code
                };
            }
            catch (PoyntSDKException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new PoyntSDKException("Failed to handle error for response.", e);
            }
        }
        protected virtual async Task<string> ReadResponse(HttpResponseMessage response)
        {
            var contentResponse = await response.Content.ReadAsStringAsync()
                                        .ConfigureAwait(false); 
            return contentResponse;
        }

        protected virtual async Task<T> ReadResponse<T>(HttpResponseMessage response)
        {
            var responseContent = await ReadResponse(response).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(responseContent, jsonSerializerSettings);
        }

        protected virtual async Task<TCollection> ReadListResponse(HttpResponseMessage response)
        {
            var result = await ReadResponse<TCollection>(response).ConfigureAwait(false);
            return result;
        }

        
        protected virtual void SetAuthorization(HttpRequestMessage requestMessage)
        {
            string accessToken = sdk.AccessToken;
            requestMessage.Headers.Add("Authorization", "Bearer " + accessToken);
        }

        protected virtual async Task<T> GetResource<T>(string resourceUrl, FilterModel filter = null)
             where T : class
        {
            T result = default(T);
            try
            {
                if (filter != null)
                {
                    resourceUrl = ApplyFilterToRequest(resourceUrl, filter);
                }

                using (HttpRequestMessage get = CreateGetRequest(resourceUrl))
                {
                    SetAuthorization(get);

                    if (filter != null && filter.IfModifiedSince.HasValue)
                    {
                        get.Headers.Add("If-Modified-Since", filter.IfModifiedSince.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssK"));
                    }

                    using (var httpClient = getHttpClient())
                    {
                        var response = await httpClient.SendAsync(get)
                            .ConfigureAwait(false); 
                        if (response.IsSuccessStatusCode)
                        {
                            result = await ReadResponse<T>(response)
                            .ConfigureAwait(false);

                            return result;
                        }
                        else
                        {
                            await HandleError(response)
                                  .ConfigureAwait(false);
                            return null;
                        }
                    }
                }
            }
            catch (PoyntSDKException)
            {
                throw;
            }
            catch (System.AggregateException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new PoyntSDKException("Failed to get resource.", e);
            }
        }

        protected virtual string ApplyFilterToRequest(string resourceUrl, FilterModel filter)
        {
            if (filter == null)
            {
                return resourceUrl;
            }

            var filters = new Dictionary<string, string>(filter.Filters);
            var type = filter.GetType();
            var props = type.GetProperties();
            foreach (var p in props)
            {
                if (p.Name == nameof(filter.Filters) || p.Name == nameof(filter.IfModifiedSince))
                {
                    continue;
                }

                var val = p.GetValue(filter);
                if (val == null)
                {
                    continue;
                }

                var sVal = string.Empty;
                if (val.GetType() == typeof(DateTime))
                {
                    sVal = ((DateTime?)val).Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssK");
                }
                else if (val.GetType() == typeof(string[]))
                {
                    sVal = string.Join(",", (string[])val);
                }
                else
                {
                    sVal = val.ToString();
                }
                filters.Add(p.Name, sVal);
            }

            var res = Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(resourceUrl, filters);

            return res;
        }

        protected HttpMethod ConvertToHttpMethod(HttpMethods method)
        {
            switch (method)
            {
                case HttpMethods.Post:
                    return HttpMethod.Post;
                case HttpMethods.Delete:
                    return HttpMethod.Delete;
                case HttpMethods.Put:
                    return HttpMethod.Put;
                case HttpMethods.Options:
                    return HttpMethod.Options;
                case HttpMethods.Trace:
                    return HttpMethod.Trace;
                case HttpMethods.PATCH:
                    return new HttpMethod("PATCH");
                default:
                    return HttpMethod.Post;
            }
        }

        protected async Task<T> PostResource<T>(T entity, 
            string resourceUrl, HttpMethods method = HttpMethods.Post) where T : class
        {
            T result = default(T);
            try
            {
                HttpRequestMessage request;
                request = CreatePostRequest(resourceUrl, ConvertToHttpMethod(method));

                //var method = new HttpMethod("PATCH");

                using (request)
                {
                    SetAuthorization(request);

                    if (entity != null)
                    {
                        var json = JsonConvert.SerializeObject(entity, jsonSerializerSettings);
                        //construct content to send
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        request.Content = content;
                    }

                    using (var httpClient = getHttpClient())
                    {
                        var response = await httpClient.SendAsync(request)
                            .ConfigureAwait(false); 

                        var httpCode = response.StatusCode;
                        if (httpCode == HttpStatusCode.Accepted || httpCode == HttpStatusCode.NoContent)
                        {
                            // no result
                            result = null;
                        }
                        else if (httpCode == HttpStatusCode.Created || httpCode == HttpStatusCode.OK)
                        {
                            result = await ReadResponse<T>(response)
                                            .ConfigureAwait(false); 
                        }
                        else
                        {
                            await HandleError(response)
                                    .ConfigureAwait(false);
                        }

                    }
                }
            }
            catch (PoyntSDKException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new PoyntSDKException("Failed to create resource.", e);
            }
            return result;
        }

        public async Task<TCollection> GetAll(FilterModel filter = null)
        {
            string baseUrl = endPoint();
            return await GetResource<TCollection>(baseUrl, filter);
        }

        public async Task<TModel> Get(string itemId, FilterModel filter = null)
        {
            var link = endPoint();
            string baseUrl = string.IsNullOrWhiteSpace(itemId) ? link : link + "/" + itemId;
            return await GetResource<TModel>(baseUrl, filter);
        }

        public async Task<TModel> Create(TModel resource) 
        {
            string baseUrl = endPoint();
            return await PostResource<TModel>(resource, baseUrl);
        }

        public async Task<TModel> Update(TModel resource)
        {
            string baseUrl = endPoint();
            return await PostResource<TModel>(resource, baseUrl, HttpMethods.Put);
        }

        public async Task<TModel> Patch(TModel resource)
        {
            string baseUrl = endPoint();
            return await PostResource<TModel>(resource, baseUrl, HttpMethods.PATCH);
        }

        public async Task Delete(string id)
        {
            string baseUrl = endPoint() + "/" + id;
            var res = await PostResource<TModel>(null, baseUrl, HttpMethods.Delete);
            return;
        }
    }
}
