using System.Net;

namespace CleanArchitecture.XCutting.HandleErrors
{
    public sealed record Error(HttpStatusCode Code, string Description) { }
}
