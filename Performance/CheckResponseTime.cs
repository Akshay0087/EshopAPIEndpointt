using EshopAPIEndpoint.specs.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
