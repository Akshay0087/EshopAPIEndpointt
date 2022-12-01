using EshopAPIEndpoint.specs.APIResults;
using EshopAPIEndpoint.specs.APIResults.DeleteRequestResult;
using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.APIResults.PutRequestResult;

namespace EshopAPIEndpoint.specs.Data_manipulation
{
    public static class ResetRequestResult
    {
        public static void ResetRequestResponses()
        {
            DeleteItemCatalogResult.ResetDeleteResult();
            GetCatalogItemResult.ResetGetItemResult();
            GetCatalogItemsResult.ResetGetItemsResult();
            PostAuthenticationResult.ResetPostAuthenticataionResult();
            PostCatalogItemResult.ResetPostAuthenticataionResult();
            PutItemCatalogResult.ResetPutItemResult();
        }
    }
}
