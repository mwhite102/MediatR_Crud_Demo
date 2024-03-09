using MediatR;

namespace MediatRDemo.Commands
{
    /// <summary>
    /// Simple ping object implementing IRequest<string>
    /// </summary>
    public class PingCommand : IRequest<string>
    {

    }
}
