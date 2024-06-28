using MediatR;
using LeadsManagement.Models;

namespace LeadsManagement.Application.Features.Queries;
public record GetAcceptedContactsQuery : IRequest<IEnumerable<AcceptedContact>>
{
}
