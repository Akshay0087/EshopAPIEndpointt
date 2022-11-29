using EshopAPIEndpoint.specs.Model;
using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.APIResults.PostRequestResult
{
    public static class PostAuthenticationResult
    {
        public static int statusCode;
        public static IReadOnlyCollection<HeaderParameter> header;
        public static Authentication authentication;
        public static string serverResponse;
    }
}
