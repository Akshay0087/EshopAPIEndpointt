using EshopAPIEndpoint.specs.APIResults;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
namespace EshopAPIEndpoint.specs.CallAPI
{
    public class GetAPIEndpoint
    {
        public bool GetCatalogueItems()
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
                response = client.Execute(request);
                GetCatalogItemsResult.catalogueItemList = JsonConvert.DeserializeObject<CatalogItems>(response.Content);
                GetCatalogItemsResult.statusCode = (int)response.StatusCode;
                GetCatalogItemsResult.header = response.Headers;
                GetCatalogItemsResult.serverResponse = response.Content;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response.IsSuccessful;
        }
        public bool GetCatalogueItem(int id)
        {
            RestResponse response;
            var client = new RestClient("https://localhost:44339/api/");
            var request = new RestRequest("catalog-items/{item-id}", Method.Get);
            request.AddUrlSegment("item-id", 2);
            request.OnBeforeDeserialization = resp =>
            {
                resp.ContentType = "application/json";
            };
            try
            {
                response = client.Execute(request);
                GetCatalogItemResult.catalogItem = JsonConvert.DeserializeObject<GetItemDetail>(response.Content).catalogItem;
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