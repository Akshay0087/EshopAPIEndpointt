using static EshopAPIEndpoint.specs.APIResults.DeleteRequestResult.DeleteItemCatalogResult;
using static EshopAPIEndpoint.specs.Performance.StopWatchHelper;
using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Performance;
using RestSharp;
using System;

namespace EshopAPIEndpoint.specs.CallAPI
{
    public static class DeleteAPIEndpoint
    {
        public static bool DeleteCatalogItem(int itemID)
        {
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(DeleteAPIConstant.deleteItemUri, Method.Delete);
            request.AddHeader("Authorization", "Bearer " + PostAuthenticationResult.token);
            try
            {
               StartStopwatch();
                response = client.Execute(request);
                executionTime = StopStopwatch();
                statusCode = (int)response.StatusCode;
                header = response.Headers;
                serverResponse = response.Content;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
    }
}