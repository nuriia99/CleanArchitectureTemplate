using System.Net;

namespace CleanArchitecure.XCutting.HandleErrors
{
    public sealed record Error(HttpStatusCode Code, string Description) { }
}
