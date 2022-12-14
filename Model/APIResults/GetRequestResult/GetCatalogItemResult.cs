using EshopAPIEndpoint.specs.Model;
using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.APIResults
{
    public static class GetCatalogItemResult
    {
        public static int statusCode { get; set; }
        public static IReadOnlyCollection<HeaderParameter> header { get; set; }
        public static CatalogItem catalogItem { get; set; }
        public static string serverResponse { get; set; }
        public static decimal executionTime { get; set; }

        public static void ResetGetItemResult()
        {
            statusCode = 0;
            header = null;
            catalogItem=null;
            serverResponse= null;
            executionTime = 0;
        }
    }
}
