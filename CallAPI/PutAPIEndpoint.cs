using EshopAPIEndpoint.specs.APIResults;
using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.APIResults.PutRequestResult;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Model;
using EshopAPIEndpoint.specs.Performance;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
namespace EshopAPIEndpoint.specs.CallAPI
{
    public class PutAPIEndpoint
    {
        public bool PutCataogItem(CatalogItem catalogItem)
        {
            string requestOutput;
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(PutAPIConstant.updateItemCatalog, Method.Put);
            request.AddHeader("Authorization", "Bearer " + PostAuthenticationResult.authentication.token);
            JObject item = JObject.Parse(PostItemCatalogToJson.CatalogItemObjectToJson(catalogItem));
            item["id"] = catalogItem.Id;
            request.AddParameter("application/json", JsonConvert.SerializeObject(item), ParameterType.RequestBody);
            try
            {
                StopwatchTimer.stopWatch.StartStopwatch();
                response = client.Execute(request);
                PutItemCatalogResult.exexecutionTime = StopwatchTimer.stopWatch.StopStopwatch();
                requestOutput = response.Content;
                PutItemCatalogResult.statusCode = (int)response.StatusCode;
                PutItemCatalogResult.header = response.Headers;
                PutItemCatalogResult.serverResponse = response.Content;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
    }
}