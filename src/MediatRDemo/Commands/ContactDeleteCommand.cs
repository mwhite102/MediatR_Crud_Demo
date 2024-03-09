using MediatR;
using MediatRDemo.Models;

namespace MediatRDemo.Commands
{
    public class ContactDeleteCommand : IRequest
    {
        public ContactDeleteCommand(Contact contact)
        {
            Contact = contact;
        }

        public Contact Contact { get; }
    }
}
