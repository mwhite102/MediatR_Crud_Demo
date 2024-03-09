using MediatR;
using MediatRDemo.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Simple ping test to make sure the service is up
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new PingCommand()));
        }
    }
}
