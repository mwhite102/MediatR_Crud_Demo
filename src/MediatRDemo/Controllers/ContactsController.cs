using MediatR;
using MediatRDemo.Commands;
using MediatRDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : Controller
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            return Ok(await _mediator.Send(new ContactListCommand()));
        }

        [HttpGet("{id}", Name = "DetailsAsync")]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            return Ok(await _mediator.Send(new ContactDetailsCommand(id)));
        }

        [HttpPost]        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateAsync([FromBody] ContactCreateCommand request)
        {
            Contact contact = await _mediator.Send(request);
            return CreatedAtRoute(nameof(DetailsAsync), new { id = contact.ContactId }, contact);
            
        }

        [HttpPatch]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] ContactUpdateCommand request)
        {
            await _mediator.Send(request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            Contact contact = await _mediator.Send(new ContactDetailsCommand(id));
            if (contact == null)
                return NotFound();
       
            
            await _mediator.Send(new ContactDeleteCommand(contact));
            return NoContent();
        }
    }
}
