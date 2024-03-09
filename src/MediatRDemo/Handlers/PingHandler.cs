using MediatR;
using MediatRDemo.Commands;

namespace MediatRDemo.Handlers
{
    /// <summary>
    /// Handler for <see cref="PingCommand"/>
    /// </summary>
    public class PingHandler : IRequestHandler<PingCommand, string>
    {
        /// <summary>
        /// Handles <see cref="PingCommand"/>
        /// </summary>
        /// <param name="request">The request object</param>
        /// <param name="cancellationToken"></param>
        /// <returns>A string result</returns>
        public Task<string> Handle(PingCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong");
        }
    }
}
