using MediatR;
using MediatRDemo.Data;
using MediatRDemo.Models;
using MediatRDemo.Commands;

namespace MediatRDemo.Handlers
{
    public class ContactDetailsHandler : IRequestHandler<ContactDetailsCommand, Contact>
    {
        private readonly ContactsDbContext _context;

        public ContactDetailsHandler(ContactsDbContext context)
        {
            this._context = context;
        }

        public Task<Contact?> Handle(ContactDetailsCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_context.Contacts.Where(o => o.ContactId == request.Id).FirstOrDefault());
        }
    }
}
