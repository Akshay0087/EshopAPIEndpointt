using Xunit;

namespace EshopAPIEndpoint.specs.StatusCodeValidation
{
    public static class SuccessResponse
    {
        public static void OKStatus(int status) { 
            Assert.True(status==200,"Status not equal to 200");
        }
        public static void CreatedStatus(int status)
        {
            Assert.True(status == 201, "Status not equal to 201");
        }
    }
}
