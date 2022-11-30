using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.APIResults.DeleteRequestResult
{
    public class DeleteItemCatalogResult
    {
        public static int statusCode { get; set; }
        public static IReadOnlyCollection<HeaderParameter> header { get; set; }
        public static string serverResponse { get; set; }
        public static decimal executionTime { get; set; }
    }
}
