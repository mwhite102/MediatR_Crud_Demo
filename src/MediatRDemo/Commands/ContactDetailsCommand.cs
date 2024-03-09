using MediatR;
using MediatRDemo.Models;

namespace MediatRDemo.Commands
{
    public class ContactDetailsCommand : IRequest<Contact>
    {
        public ContactDetailsCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
