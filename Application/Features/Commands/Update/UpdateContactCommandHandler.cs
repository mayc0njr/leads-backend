using LeadsManagement.Application.Interfaces;
using LeadsManagement.Entities;
using LeadsManagement.Repository;
using MediatR;

namespace LeadsManagement.Applications.Features.Commands.Update;
public class UpdateContactCommandHandler : IRequestHandler<UpdateContactStatusCommand, Contact>
{
    private readonly IApplicationDbContext _dbContext;

    public UpdateContactCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Contact> Handle(UpdateContactStatusCommand request, CancellationToken cancellationToken)
    {
        var contact = _dbContext.Contacts.FirstOrDefault(c => c.Id == request.Id);

        if (contact is null)
            return default;

        contact.Status = request.Status;
        await _dbContext.SaveChangesAsync(cancellationToken);
        return contact;
    }
}