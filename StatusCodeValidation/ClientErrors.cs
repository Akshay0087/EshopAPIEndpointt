using Xunit;

namespace EshopAPIEndpoint.specs.StatusCodeValidation
{
    public static class ClientErrors
    {
        public static void NotFoundStatus(int status)
        {
            Assert.True(status == 404, "Status not equal to 404");
        }
        public static void UnauthorizedStatus(int status)
        {
            Assert.True(status == 401, "Status not equal to 401");
        }
        public static void ForbiddenStatus(int status)
        {
            Assert.True(status == 403, "Status not equal to 403");
        }
    }
}
