using EshopAPIEndpoint.specs.APIResults;
using EshopAPIEndpoint.specs.CallAPI;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Performance;
using EshopAPIEndpoint.specs.StatusCodeValidation;
using System;
using TechTalk.SpecFlow;

namespace EshopAPIEndpoint.specs.StepDefinitions
{
    [Binding]
    public class GetRequestStepDefinitions
    {
        [When(@"User input item id ""([^""]*)""")]
        public void WhenUserInputItemId(string itemId)
        {
            GetAPIEndpoint.GetCatalogueItem(Convert.ToInt32(itemId));
        }

        [Then(@"Server Response status for getting the item should be OK")]
        public void ThenServerResponseStatusForGettingTheItemShouldBeOK()
        {
            SuccessResponse.OKStatus(GetCatalogItemResult.statusCode);
        }

        [Then(@"server Response Header for getting the item should be valid")]
        public void ThenServerResponseHeaderForGettingTheItemShouldBeValid()
        {
            Headervalidation.HeaderTest(GetCatalogItemResult.header);
        }

        [Then(@"Server Response content for getting the item should be valid")]
        public void ThenServerResponseContentForGettingTheItemShouldBeValid()
        {
            ServerResponseValidation.ResponseValidation(GetCatalogItemResult.serverResponse, 
                "C:\\Users\\P129FA4\\source\\repos\\EshopAPIEndpoint.specs\\ServerResponseJsonSchema\\GetCatalogItemResponseSchema.json");
        }

        [Then(@"Response time for getting the item is between acceptable range")]
        public void ThenResponseTimeForGettingTheItemIsBetweenAcceptableRange()
        {
            CheckResponseTime.ResponseTimeValidator(GetCatalogItemResult.executionTime);
        }

        [Then(@"Response time for getting the items is between acceptable range")]
        public void ThenResponseTimeForGettingTheItemsIsBetweenAcceptableRange()
        {
            CheckResponseTime.ResponseTimeValidator(GetCatalogItemsResult.executionTime);
        }
        [When(@"User request all items details")]
        public void WhenUserRequestAllItemsDetails()
        {
            GetAPIEndpoint.GetCatalogueItems();
        }


        [Then(@"Server Response status for getting the items should be OK")]
        public void ThenServerResponseStatusForGettingTheItemsShouldBeOK()
        {
            SuccessResponse.OKStatus(GetCatalogItemsResult.statusCode);
        }

        [Then(@"Server Response content for getting the items should be valid")]
        public void ThenServerResponseContentForGettingTheItemsShouldBeValid()
        {
            ServerResponseValidation.ResponseValidation(GetCatalogItemsResult.serverResponse, 
                "C:\\Users\\P129FA4\\source\\repos\\EshopAPIEndpoint.specs\\ServerResponseJsonSchema\\GetCatalogItemsResponseSchema.json");
        }

    }
}
