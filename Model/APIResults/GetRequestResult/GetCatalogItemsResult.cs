using EshopAPIEndpoint.specs.Model;
using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.APIResults
{
    public static class GetCatalogItemsResult
    {
        public static int statusCode;
        public static IReadOnlyCollection<HeaderParameter> header;
        public static CatalogItems catalogueItemList;
        public static string serverResponse;
    }
}
