using EshopAPIEndpoint.specs.Model;
using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.APIResults
{
    public static class GetCatalogItemResult
    {
        public static int statusCode;
        public static IReadOnlyCollection<HeaderParameter> header;
        public static CatalogItem catalogItem;
        public static string serverResponse;
    }
}
