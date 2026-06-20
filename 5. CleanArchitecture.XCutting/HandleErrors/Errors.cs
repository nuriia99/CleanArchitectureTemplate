using System.Net;

namespace CleanArchitecture.XCutting.HandleErrors
{
    public static class Errors
    {
        public static readonly Error MailNotFoundError = new(
            HttpStatusCode.NotFound, "Not found a user with that email.");
    }

}
