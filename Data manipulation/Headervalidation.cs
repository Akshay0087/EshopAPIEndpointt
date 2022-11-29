using RestSharp;
using System.Collections.Generic;

namespace EshopAPIEndpoint.specs.Data_manipulation
{
    public class Headervalidation
    {

        public Dictionary<string,string> HeaderTest(IReadOnlyCollection<HeaderParameter> responseHeader) { 
            Dictionary<string,string> headerList = new Dictionary<string,string>();

            foreach(var item in responseHeader)
            {
                string[] keypairs=item.ToString().Split('=');
                headerList.Add(keypairs[0], keypairs[1]);
            }
            
           return headerList;
        }
    }
}
