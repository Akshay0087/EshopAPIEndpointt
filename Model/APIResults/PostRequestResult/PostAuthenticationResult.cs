using EshopAPIEndpoint.specs.Model;
using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.APIResults.PostRequestResult
{
    public class PostAuthenticationResult
    {
        public static int statusCode { get; set; }
        public static IReadOnlyCollection<HeaderParameter> header { get; set; }
        public static string token;
        public static string serverResponse { get; set; }
        public static decimal executionTime { get; set; }
    }
}
