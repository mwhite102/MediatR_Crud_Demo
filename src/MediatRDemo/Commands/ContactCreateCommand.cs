using MediatR;
using MediatRDemo.Models;

namespace MediatRDemo.Commands
{
    public class ContactCreateCommand : IRequest<Contact>
    {
        public ContactCreateCommand(Contact contact)
        {
            Contact = contact;
        }

        public Contact Contact { get; }
    }
}
