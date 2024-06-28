using LeadsManagement.Application.Features.Commands.Delete;
using LeadsManagement.Application.Interfaces;
using MediatR;

namespace LeadsManagement.Applications.Features.Commands.Update;
public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand>
{
    private readonly IApplicationDbContext _context;
    public DeleteContactCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Unit> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Contacts
            .FindAsync(new object[] { request.Id }, cancellationToken);
        if(entity == null)
            return await Task.FromResult(Unit.Value);
        _context.Contacts.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return await Task.FromResult(Unit.Value);
    }
}