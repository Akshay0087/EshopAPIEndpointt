using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.APIResults.PutRequestResult;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using static EshopAPIEndpoint.specs.APIResults.PutRequestResult.PutItemCatalogResult;
using static EshopAPIEndpoint.specs.Performance.StopWatchHelper;
namespace EshopAPIEndpoint.specs.CallAPI
{
    public static class PutAPIEndpoint
    {
        public static bool PutCatalogItem(CatalogItem catalogItem)
        {
            string requestOutput;
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(PutAPIConstant.updateItemCatalog, Method.Put);
            request.AddHeader("Authorization", "Bearer " + PostAuthenticationResult.token);
            JObject item = JObject.Parse(PostItemCatalogToJson.CatalogItemObjectToJson(catalogItem));
            item["id"] = catalogItem.Id;
            request.AddParameter("application/json", JsonConvert.SerializeObject(item), ParameterType.RequestBody);
            try
            {
                StartStopwatch();
                response = client.Execute(request);
                executionTime = StopStopwatch();
                requestOutput = response.Content;
                PutItemCatalogResult.statusCode = (int)response.StatusCode;
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