using System.Net.Http;

namespace SquareConnectApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}