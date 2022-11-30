using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using static EshopAPIEndpoint.specs.APIResults.PostRequestResult.PostAuthenticationResult;
using static EshopAPIEndpoint.specs.Performance.StopWatchHelper;
namespace EshopAPIEndpoint.specs.CallAPI
{
    public static class PostAPIEndpoint
    {
        public static bool PostAuthenticationToken(string email, string password)
        {
            string requestOutput;
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(PostAPIConstants.authenticationAPIUri, Method.Post);
            var body = new
            {
                username = email,
                password = password
            };
            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(JsonConvert.SerializeObject(body), "application/json");

            try
            {
                StartStopwatch();
                response = client.Execute(request);
                executionTime = StopStopwatch();
                requestOutput = response.Content;
                JObject obj = JObject.Parse(requestOutput);
                token = (string)obj["token"];
                statusCode = (int)response.StatusCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
        public static bool PostCatalogItem(CatalogItem catalogItem)
        {
            string requestOutput;
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(PostAPIConstants.addCatalogItems, Method.Post);
            request.AddHeader("Authorization", "Bearer " + PostAuthenticationResult.token);
            request.AddParameter("application/json", PostItemCatalogToJson.CatalogItemObjectToJson(catalogItem), ParameterType.RequestBody);
            try
            {
                StartStopwatch();
                response = client.Execute(request);
                PostCatalogItemResult.executionTime = StopStopwatch();
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