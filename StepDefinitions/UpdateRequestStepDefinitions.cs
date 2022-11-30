using EshopAPIEndpoint.specs.APIResults.PutRequestResult;
using EshopAPIEndpoint.specs.CallAPI;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Performance;
using EshopAPIEndpoint.specs.StatusCodeValidation;
using System;
using TechTalk.SpecFlow;

namespace EshopAPIEndpoint.specs.StepDefinitions
{
    [Binding]
    public class UpdateRequestStepDefinitions
    {
        [When(@"User input product detail")]
        public void WhenUserInputProductDetail(Table table)
        {
            PutAPIEndpoint.PutCatalogItem(TableToCatalogItemModel.TableToCatalogItemConversion(table));
        }

        [Then(@"Server Response status for updating the item should be OK")]
        public void ThenServerResponseStatusForUpdatingTheItemShouldBeOK()
        {
            SuccessResponse.OKStatus(PutItemCatalogResult.statusCode);
        }

        [Then(@"Server Response content for updating the item should be valid")]
        public void ThenServerResponseContentForUpdatingTheItemShouldBeValid()
        {
            ServerResponseValidation.ResponseValidation(PutItemCatalogResult.serverResponse, 
                "C:\\Users\\P129FA4\\source\\repos\\EshopAPIEndpoint.specs\\ServerResponseJsonSchema\\UpdateCatalogItemResponseSchema.json");
        }

        [Then(@"Response time for updating the item is between acceptable range")]
        public void ThenResponseTimeForUpdatingTheItemIsBetweenAcceptableRange()
        {
            CheckResponseTime.ResponseTimeValidator(PutItemCatalogResult.executionTime);
        }
    }
}
