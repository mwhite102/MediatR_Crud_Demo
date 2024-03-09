using MediatR;
using MediatRDemo.Commands;
using MediatRDemo.Data;

namespace MediatRDemo.Handlers
{
    public class ContactDeleteHandler : IRequestHandler<ContactDeleteCommand>
    {
        private readonly ContactsDbContext _context;

        public ContactDeleteHandler(ContactsDbContext context)
        {
            this._context = context;
        }

        public Task Handle(ContactDeleteCommand request, CancellationToken cancellationToken)
        {
            _context.Contacts.Remove(request.Contact);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
