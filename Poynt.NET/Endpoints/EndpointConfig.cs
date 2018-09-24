using System;
using System.Collections.Generic;
using System.Text;
using Poynt.NET.Model;

namespace Poynt.NET.Endpoints
{

    public static class EndpointConfig
    {
        private static Dictionary<Type, IEndpoint> Endpoints { get; set; } = new Dictionary<Type, IEndpoint>();
        public static void Register<T>(IEndpoint endpoint)
        {
            Endpoints[typeof(T)] = endpoint;
        }

        public static IEndpoint Get<T>()
        {
            return Endpoints.ContainsKey(typeof(T)) ? Endpoints[typeof(T)] : null;
        }

        static EndpointConfig()
        {
            Register<Business>(new EndpointData(Constants.API_BUSINESSES));
            Register<CloudMessage>(new EndpointData(Constants.API_CLOUD_MESSAGES));
            Register<Hook>(new EndpointData(Constants.API_WEBHOOKS));

            var businessEndpoint = Get<Business>();

            Register<BusinessUser>(new EndpointData(Constants.API_BUSINESS_USERS, businessEndpoint));
            Register<Catalog>(new EndpointData(Constants.API_CATALOGS, businessEndpoint));
            Register<Product>(new EndpointData(Constants.API_PRODUCTS, businessEndpoint));
            Register<Transaction>(new EndpointData(Constants.API_TRANSACTIONS, businessEndpoint));
            Register<Order>(new EndpointData(Constants.API_ORDERS, businessEndpoint));
            Register<Customer>(new EndpointData(Constants.API_CUSTOMERS, businessEndpoint));
            Register<Tax>(new EndpointData(Constants.API_TAX, businessEndpoint));
            Register<Delivery>(new EndpointData(Constants.API_HOOK_DELIVERY, businessEndpoint));

            var productEndpoint = Get<Product>();
            Register<ProductSummary> (new EndpointData(Constants.API_PRODUCT_SUMMARY, productEndpoint));
            Register<Variant> (new EndpointData(Constants.API_VARIANTS, productEndpoint));

            var catalogsEndpoint = Get<Catalog>();
            Register<CatalogWithProduct>(new EndpointData(Constants.API_CATALOGS_FULL, catalogsEndpoint));
            Register<Category>(new EndpointData(Constants.API_CATEGORY, catalogsEndpoint));
            
        }

    }
}
