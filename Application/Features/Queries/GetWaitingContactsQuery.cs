using MediatR;
using LeadsManagement.Models;

namespace LeadsManagement.Application.Features.Queries;
public record GetWaitingContactsQuery : IRequest<IEnumerable<WaitingContact>>
{
}
