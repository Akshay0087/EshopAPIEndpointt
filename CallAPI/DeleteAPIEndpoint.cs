using EshopAPIEndpoint.specs.APIResults.DeleteRequestResult;
using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.Constants;
using RestSharp;
using System;
namespace EshopAPIEndpoint.specs.CallAPI
{
    public class DeleteAPIEndpoint
    {
        public bool DeleteCatalogItem(int itemID)
        {
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(DeleteAPIConstant.deleteItemUri, Method.Delete);
            request.AddHeader("Authorization", "Bearer " + PostAuthenticationResult.authentication.token);
            try
            {
                response = client.Execute(request);
                DeleteItemCatalogResult.statusCode = (int)response.StatusCode;
                DeleteItemCatalogResult.header = response.Headers;
                DeleteItemCatalogResult.serverResponse = response.Content;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
    }
}