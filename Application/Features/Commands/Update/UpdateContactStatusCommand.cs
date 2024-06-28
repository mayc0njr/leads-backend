using MediatR;
using LeadsManagement.Entities;

namespace LeadsManagement.Applications.Features.Commands.Update;
public record UpdateContactStatusCommand : IRequest<Contact>
{
    public int Id { get; set; }
    public Status Status { get; set;}
}
