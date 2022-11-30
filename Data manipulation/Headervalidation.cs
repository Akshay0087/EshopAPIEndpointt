using EshopAPIEndpoint.specs.Constants;
using RestSharp;
using System.Collections.Generic;
using Xunit;

namespace EshopAPIEndpoint.specs.Data_manipulation
{
    public static class Headervalidation
    {

        public static void HeaderTest(IReadOnlyCollection<HeaderParameter> responseHeader) { 
            Dictionary<string,string> headerList = new Dictionary<string,string>();

            foreach(var item in responseHeader)
            {
              
                headerList.Add(item.Name,item.Value.ToString());
            }

            
            Assert.True(headerList["Server"] == ResponseHeaderConstant.serverType, "Server type is not valid");
        }
    }
}
