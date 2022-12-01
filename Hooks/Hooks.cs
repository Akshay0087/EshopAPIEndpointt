using EshopAPIEndpoint.specs.APIResults.PostRequestResult;
using EshopAPIEndpoint.specs.Data_manipulation;
using TechTalk.SpecFlow;
using static EshopAPIEndpoint.specs.Data_manipulation.ResetRequestResult;

namespace EshopAPIEndpoint.specs.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            ResetRequestResponses();
        }
    }
}