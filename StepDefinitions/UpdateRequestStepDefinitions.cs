using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.APIResults.PutRequestResult;
using EshopAPIEndpoint.specs.CallAPI;
using EshopAPIEndpoint.specs.Constants;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Performance;
using EshopAPIEndpoint.specs.StatusCodeValidation;
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
        [Then(@"Server Response status for updating the item should be Internal Server Error")]
        public void ThenServerResponseStatusForUpdatingTheItemShouldBeInternalServerError()
        {

            ServerError.InternalServerErrorStatus(PutItemCatalogResult.statusCode);
        }
        [Then(@"Server Response status for updating the item should be Unauthorised")]
        public void ThenServerResponseStatusForUpdatingTheItemShouldBeUnauthorised()
        {
            ClientErrors.UnauthorizedStatus(PutItemCatalogResult.statusCode);
        }

    }
}
