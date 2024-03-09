using MediatR;
using MediatRDemo.Commands;
using MediatRDemo.Data;

namespace MediatRDemo.Handlers
{
    public class ContactUpdateHandler : IRequestHandler<ContactUpdateCommand>
    {
        private readonly ContactsDbContext _context;

        public ContactUpdateHandler(ContactsDbContext context)
        {
            this._context = context;
        }

        public Task Handle(ContactUpdateCommand request, CancellationToken cancellationToken)
        {
            _context.Contacts.Update(request.Contact);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
