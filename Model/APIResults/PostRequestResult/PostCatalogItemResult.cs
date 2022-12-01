using Gherkin;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopAPIEndpoint.specs.APIResults.PostRequestResult
{
    public static class PostCatalogItemResult
    {
        public static int statusCode { get; set; }
        public static IReadOnlyCollection<HeaderParameter> header { get; set; }
        public static string serverResponse { get; set; }
        public static decimal executionTime { get; set; }

        public static void ResetPostAuthenticataionResult()
        {
            statusCode = 0;
            header = null;
            serverResponse = null;
            executionTime = 0;
        }
    }
}
