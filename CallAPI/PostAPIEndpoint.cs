using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Model;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
namespace EshopAPIEndpoint.specs.CallAPI
{
    public class PostAPIEndpoint
    {
        public bool PostAuthenticationToken(string email, string password)
        {
            int statusCode;
            string requestOutput;
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(PostAPIConstants.authenticationAPIUri, Method.Post);
            try
            {
                response = client.Execute(request);
                requestOutput = response.Content;
                JObject obj = JObject.Parse(requestOutput);
                PostAuthenticationResult.authentication.token = (string)obj["token"];
                PostAuthenticationResult.statusCode = (int)response.StatusCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
        public bool PostCatalogItem(CatalogItem catalogItem)
        {
            string requestOutput;
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(PostAPIConstants.addCatalogItems, Method.Post);
            request.AddHeader("Authorization", "Bearer " + PostAuthenticationResult.authentication.token);
            request.AddParameter("application/json", PostItemCatalogToJson.CatalogItemObjectToJson(catalogItem), ParameterType.RequestBody);
            try
            {
                response = client.Execute(request);
                requestOutput = response.Content;
                PostCatalogItemResult.statusCode = (int)response.StatusCode;
                PostCatalogItemResult.header = response.Headers;
                PostCatalogItemResult.serverResponse = response.Content;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
    }
}