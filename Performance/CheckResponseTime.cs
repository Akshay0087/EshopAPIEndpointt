using EshopAPIEndpoint.specs.Constants;
using Xunit;

namespace EshopAPIEndpoint.specs.Performance
{
    public static class CheckResponseTime
    {
        public static void ResponseTimeValidator(decimal serverResponseTime)
        {
            bool status = false;
            if(serverResponseTime >= ServerResponseTimeConstant.minTime && serverResponseTime <= ServerResponseTimeConstant.maxTime)
            {
                status = true;
            }
            Assert.True(status, "Reponse time was not in between threshold. Response time:" + serverResponseTime);
        }
    }
}
