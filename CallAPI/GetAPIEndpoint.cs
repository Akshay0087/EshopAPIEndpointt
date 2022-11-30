using EshopAPIEndpoint.specs.APIResults;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using static EshopAPIEndpoint.specs.APIResults.GetCatalogItemsResult;
using static EshopAPIEndpoint.specs.Performance.StopWatchHelper;
namespace EshopAPIEndpoint.specs.CallAPI
{
    public static class GetAPIEndpoint
    {
        public static bool GetCatalogueItems()
        {
            RestResponse response;
            var client = new RestClient(GeneralAPIEndpoint.generalAPIuri);
            var request = new RestRequest(GetAPIConstant.getCatalogItems, Method.Get);
            request.OnBeforeDeserialization = resp =>
            {
                resp.ContentType = "application/json";
            };
            try
            {
                StartStopwatch();
                response = client.Execute(request);
                executionTime = StopStopwatch();
                catalogueItemList = JsonConvert.DeserializeObject<CatalogItems>(response.Content);
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
        public static bool GetCatalogueItem(int id)
        {
            RestResponse response;
            var client = new RestClient("https://localhost:44339/api/");
            var request = new RestRequest("catalog-items/{item-id}", Method.Get);
            request.AddUrlSegment("item-id", id);
            request.OnBeforeDeserialization = resp =>
            {
                resp.ContentType = "application/json";
            };
            try
            {
                StartStopwatch();
                response = client.Execute(request);
                GetCatalogItemResult.executionTime = StopStopwatch();
                GetCatalogItemResult.serverResponse = response.Content;
                //GetCatalogItemResult.catalogItem = JsonConvert.DeserializeObject<GetItemDetail>(response.Content);
                GetCatalogItemResult.statusCode = (int)response.StatusCode;
                GetCatalogItemResult.header = response.Headers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
    }
}