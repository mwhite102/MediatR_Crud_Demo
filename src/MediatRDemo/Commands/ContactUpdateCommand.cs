using MediatR;
using MediatRDemo.Models;

namespace MediatRDemo.Commands
{
    public class ContactUpdateCommand : IRequest
    {
        public ContactUpdateCommand(Contact contact)
        {
            Contact = contact;
        }

        public Contact Contact { get; }
    }
}
