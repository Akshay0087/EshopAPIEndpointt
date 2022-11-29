using RestSharp;
using TechTalk.SpecFlow;
using Xunit;

namespace EshopAPITest.specs.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        [Then(@"Get Is Successful")]
        public void ThenGetIsSuccessful()
        {
            var url = "https://localhost:44339/api/catalog-brands";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = client.Execute(request);
            var Output = response.Content;
            var code=(int)response.StatusCode;
            Assert.Equal(200,(int)response.StatusCode);
        }

        [Then(@"Post Is Successful")]
        public void ThenPostIsSuccessful()
        {
            var url = "https://localhost:44339/api/catalog-brands";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = client.Execute(request);
            var Output = response.Content;
            var code = (int)response.StatusCode;
            Assert.Equal(200, (int)response.StatusCode);
        }
    }
}
