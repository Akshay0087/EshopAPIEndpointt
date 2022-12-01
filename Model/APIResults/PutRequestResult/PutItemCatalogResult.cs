using Gherkin;
using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.APIResults.PutRequestResult
{
    public class PutItemCatalogResult
    {
        public static int statusCode { get; set; }
        public static IReadOnlyCollection<HeaderParameter> header { get; set; }
        public static string serverResponse { get; set; }
        public static decimal executionTime { get; set; }

        public static void ResetPutItemResult()
        {
            statusCode = 0;
            header = null;
            serverResponse = null;
            executionTime = 0;
        }
    }
}
