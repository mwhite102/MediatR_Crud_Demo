using MediatR;
using MediatRDemo.Data;
using MediatRDemo.Models;
using MediatRDemo.Commands;

namespace MediatRDemo.Handlers
{
    public class ContactListHandler : IRequestHandler<ContactListCommand, List<Contact>>
    {
        private readonly ContactsDbContext _context;

        public ContactListHandler(ContactsDbContext context)
        {
            this._context = context;
        }

        public Task<List<Contact>> Handle(ContactListCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_context.Contacts.ToList());
        }
    }
}
