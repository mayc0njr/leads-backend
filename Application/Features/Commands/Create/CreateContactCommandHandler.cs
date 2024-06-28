using LeadsManagement.Application.Interfaces;
using LeadsManagement.Entities;
using MediatR;

namespace LeadsManagement.Application.Features.Commands.Create;
public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, int>
{
    private readonly IApplicationDbContext _context;
    public CreateContactCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(CreateContactCommand request,
    CancellationToken cancellationToken)
    {
        var entity = new Contact
        {
            Name = request.Name,
            CategoryId = request.CategoryId,
            Description = request.Description,
            Email = request.Email,
            Phone = request.Phone,
            Price = request.Price,
            Suburb = request.Suburb,
        };
        _context.Contacts.Add(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return entity.Id;
    }
}