using Xunit;

namespace EshopAPIEndpoint.specs.StatusCodeValidation
{
    public static class ServerError
    {
        public static void InternalServerErrorStatus(int status)
        {
            Assert.True(status == 500, "Status not equal to 500");
        }
    }
}
