using EshopAPIEndpoint.specs.APIResults.DeleteRequestResult;
using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.CallAPI;
using EshopAPIEndpoint.specs.Data_manipulation;
using EshopAPIEndpoint.specs.Performance;
using EshopAPIEndpoint.specs.StatusCodeValidation;
using TechTalk.SpecFlow;
using Xunit;

namespace EshopAPIEndpoint.specs.StepDefinitions
{
    [Binding]
    public class PostRequestStepDefinitions
    {
        [Given(@"User is logged with email address ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenUserIsLoggedWithEmailAddressAndPassword(string emailAddress, string password)
        {
            PostAPIEndpoint.PostAuthenticationToken(emailAddress, password);
        }

        [Given(@"User is authenticated")]
        public void GivenUserIsAuthenticated()
        {
            Assert.False(PostAuthenticationResult.token == "", "User is not authenticated");
        }

        [When(@"User add item")]
        public void WhenUserAddItem(Table table)
        {
            var catalogItem = TableToCatalogItemModel.TableToCatalogItemConversion(table);
            PostAPIEndpoint.PostCatalogItem(catalogItem);
        }

        [Then(@"Server Response status should be Created")]
        public void ThenServerResponseStatusShouldBeCreated() { 
            SuccessResponse.CreatedStatus(PostCatalogItemResult.statusCode);
        }

        [Then(@"Response time for authentication is between acceptable range")]
        public void ThenResponseTimeForAuthenticationIsBetweenAcceptableRange()
        {
            CheckResponseTime.ResponseTimeValidator(PostAuthenticationResult.executionTime);
        }

        [Then(@"Response time for creating item is between acceptable range")]
        public void ThenResponseTimeForCreatingItemIsBetweenAcceptableRange()
        {
            CheckResponseTime.ResponseTimeValidator(PostCatalogItemResult.executionTime);
        }

        [Then(@"Server Response status should be Unauthorized")]
        public void ThenServerResponseStatusShouldBeUnauthorized()
        {
            ClientErrors.UnauthorizedStatus(PostCatalogItemResult.statusCode);
        }
        
        [Then(@"Server Response status should be Conflict")]
        public void ThenServerResponseStatusShouldBeConflict()
        {
            ClientErrors.ConflictStatus(PostCatalogItemResult.statusCode);
        }
        



    }
}
