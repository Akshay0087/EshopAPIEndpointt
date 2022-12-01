using EshopAPIEndpoint.specs.APIResults.DeleteRequestResult;
using EshopAPIEndpoint.specs.CallAPI;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Performance;
using EshopAPIEndpoint.specs.StatusCodeValidation;
using System;
using TechTalk.SpecFlow;

namespace EshopAPIEndpoint.specs.StepDefinitions
{
    [Binding]
    public class DeleteRequestStepDefinitions
    {
        [When(@"User enters item id ""([^""]*)""")]
        public void WhenUserEntersItemId(string itemId)
        {
            DeleteAPIEndpoint.DeleteCatalogItem(Convert.ToInt16(itemId));
        }

        [Then(@"Server Response status for deleting an item should be OK")]
        public void ThenServerResponseStatusForDeletingAnItemShouldBeOK()
        {
            SuccessResponse.OKStatus(DeleteItemCatalogResult.statusCode);
        }

        [Then(@"Server Response content for deleting an item should be valid")]
        public void ThenServerResponseContentForDeletingAnItemShouldBeValid()
        {
            ServerResponseValidation.ResponseValidation(DeleteItemCatalogResult.serverResponse, 
                "C:\\Users\\P129FA4\\source\\repos\\EshopAPIEndpoint.specs\\ServerResponseJsonSchema\\DeleteCatalogItemResponseSchema.json");
        }

        [Then(@"server Response Header for deleting an item should be valid")]
        public void ThenServerResponseHeaderForDeletingAnItemShouldBeValid()
        {
            Headervalidation.HeaderTest(DeleteItemCatalogResult.header);
        }

        [Then(@"Response time for deleting item is between acceptable range")]
        public void ThenResponseTimeForDeletingItemIsBetweenAcceptableRange()
        {
            CheckResponseTime.ResponseTimeValidator(DeleteItemCatalogResult.executionTime);
        }

        [Then(@"Server Response status should be unauthorised")]
        public void ThenServerResponseStatusShouldBeUnauthorised()
        {
            ClientErrors.UnauthorizedStatus(DeleteItemCatalogResult.statusCode);
        }

        [Then(@"Server Response status for deleting an item should be Not Found")]
        public void ThenServerResponseStatusForDeletingAnItemShouldBeNotFound()
        {
            ClientErrors.NotFoundStatus(DeleteItemCatalogResult.statusCode);
        }
    }
}
