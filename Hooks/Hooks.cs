using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using TechTalk.SpecFlow;

namespace EshopAPIEndpoint.specs.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            PostAuthenticationResult.token = "";
        }
    }
}