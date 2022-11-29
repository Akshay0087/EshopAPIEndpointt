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
        public static int statusCode;
        public static IReadOnlyCollection<HeaderParameter> header;
        public static string serverResponse;
    }
}
