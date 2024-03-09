using MediatR;
using MediatRDemo.Data;
using MediatRDemo.Commands;
using MediatRDemo.Models;

namespace MediatRDemo.Handlers
{
    public class ContactCreateHandler : IRequestHandler<ContactCreateCommand, Contact>
    {
        private readonly ContactsDbContext _context;

        public ContactCreateHandler(ContactsDbContext context)
        {
            this._context = context;
        }

        public Task<Contact> Handle(ContactCreateCommand request, CancellationToken cancellationToken)
        {
            _context.Contacts.Add(request.Contact);
            _context.SaveChanges();
            return Task.FromResult(request.Contact);
        }
    }
}
