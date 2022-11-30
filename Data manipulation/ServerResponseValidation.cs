using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.IO;
using Xunit;

namespace EshopAPIEndpoint.specs.Data_manipulation
{
    public static class ServerResponseValidation
    {
        public static void ResponseValidation(string serverResponse,string jsonFile) { 


            JSchema jsonSchema = JSchema.Parse(File.ReadAllText(jsonFile));
            JObject response = JObject.Parse(serverResponse);
            bool valid = response.IsValid(jsonSchema);
            Assert.True(valid,"Schema not valid");
        }
    }
}
