﻿using Newtonsoft.Json;
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
    public class Api<TModel, TCollection> 
        where TModel: class
        where TCollection : class
    {
        protected PoyntSDK sdk;
        protected string endPoint;
        protected JsonSerializerSettings jsonSerializerSettings;

        public Api(PoyntSDK sdk, string endPoint)
        {
            this.sdk = sdk;
            this.endPoint = endPoint;

            jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonSerializerSettings.Converters.Add(new StringEnumConverter());
            jsonSerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
        }

        protected HttpRequestMessage CreateGetRequest(string url)
        {
            HttpRequestMessage get = new HttpRequestMessage(HttpMethod.Get, url);
            get.SetCommonApiHeaders(sdk.ClientConfig);
            return get;
        }

        protected HttpRequestMessage CreatePostRequest(String url)
        {
            HttpRequestMessage post = new HttpRequestMessage(HttpMethod.Post, url);
            post.SetCommonApiHeaders(sdk.ClientConfig);

            return post;
        }

        protected HttpRequestMessage CreateDeleteRequest(String url)
        {
            HttpRequestMessage post = new HttpRequestMessage(HttpMethod.Delete, url);
            post.SetCommonApiHeaders(sdk.ClientConfig);

            return post;
        }

        public async Task HandleError(HttpResponseMessage response)
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
        private async Task<string> ReadResponse(HttpResponseMessage response)
        {
            var contentResponse = await response.Content.ReadAsStringAsync()
                                        .ConfigureAwait(false); 
            return contentResponse;
        }

        public async Task<T> ReadResponse<T>(HttpResponseMessage response)
        {
            var responseContent = await ReadResponse(response).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(responseContent, jsonSerializerSettings);
        }

        public async Task<TCollection> ReadListResponse(HttpResponseMessage response)
        {
            var result = await ReadResponse<TCollection>(response).ConfigureAwait(false);
            return result;
        }

        private HttpClient GetHttpClient()
        {
            return new HttpClient();
        }

        private void SetAuthorization(HttpRequestMessage requestMessage)
        {
            string accessToken = sdk.AccessToken;
            requestMessage.Headers.Add("Authorization", "Bearer " + accessToken);
        }

        protected async Task<T> GetResource<T>(string resourceUrl, 
            IDictionary<string, string> nvc = null)
             where T : class
        {
            T result = default(T);
            try
            {
                if (nvc != null) {
                    resourceUrl = Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(resourceUrl, nvc);
                }

                using (HttpRequestMessage get = CreateGetRequest(resourceUrl))
                {
                    SetAuthorization(get);
                    
                    using (var httpClient = GetHttpClient())
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

        public async Task<TModel> Get(string itemId)
        {
            string baseUrl = endPoint + "/" + itemId;
            return await GetResource<TModel>(baseUrl);
        }

        public async Task<TModel> GetFromBusiness(string businessId, string resourceId)
        {
            string baseUrl = endPoint.Replace("{businessId}", businessId) + "/" + resourceId;
            return await GetResource<TModel>(baseUrl);
        }

        public async Task<TCollection> GetAllFromBusiness(string businessId)
        {
            var nvc = new Dictionary<string, string>();
            string baseUrl = endPoint;
            if (baseUrl.Contains("{businessId}"))
            {
                baseUrl = endPoint.Replace("{businessId}", businessId);
            }
            else
            {
                nvc.Add("businessId", businessId);
            }
            return await GetResource<TCollection>(baseUrl, nvc);
        }

        protected async Task<T> PostResource<T>(T entity, 
            string resourceUrl, HttpMethods method = HttpMethods.Post) where T : class
        {
            T result = default(T);
            try
            {
                HttpRequestMessage request;
                switch (method)
                {
                    case HttpMethods.Post:
                        request = CreatePostRequest(resourceUrl);
                        break;
                    case HttpMethods.Delete:
                        request = CreateDeleteRequest(resourceUrl);
                        break;
                    default:
                        request = CreateDeleteRequest(resourceUrl);
                        break;
                }
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

                    using (var httpClient = GetHttpClient())
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
        public async Task<TModel> Create(TModel resource) 
        {
            string baseUrl = endPoint;
            return await PostResource<TModel>(resource, baseUrl);
        }

        public async Task<TModel> CreateAtBusiness(TModel resource, 
            string businessId)
        {
            string baseUrl = endPoint.Replace("{businessId}", businessId);
            return await PostResource<TModel>(resource, baseUrl);
        }

        public async Task Delete(string id)
        {
            string baseUrl = endPoint + "/" + id;
            var res = await PostResource<TModel>(null, baseUrl, HttpMethods.Delete);
            return;
        }
    }
}