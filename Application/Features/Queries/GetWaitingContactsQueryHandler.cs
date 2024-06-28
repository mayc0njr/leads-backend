using MediatR;
using Microsoft.EntityFrameworkCore;
using LeadsManagement.Entities;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using LeadsManagement.Application.Interfaces;
using LeadsManagement.Models;

namespace LeadsManagement.Application.Features.Queries;
public class GetWaitingContactsQueryHandler : IRequestHandler<GetWaitingContactsQuery, IEnumerable<WaitingContact>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetWaitingContactsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<WaitingContact>> Handle(GetWaitingContactsQuery request, CancellationToken cancellationToken) =>
        await _context.Contacts.Where((c) => c.Status == Status.WAITING)
            .ProjectTo<WaitingContact>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
}
