using MediatR;
using MediatRDemo.Models;

namespace MediatRDemo.Commands
{
    public class ContactListCommand : IRequest<List<Contact>>
    {

    }
}
