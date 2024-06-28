using MediatR;
using Microsoft.EntityFrameworkCore;
using LeadsManagement.Entities;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using LeadsManagement.Application.Interfaces;
using LeadsManagement.Models;

namespace LeadsManagement.Application.Features.Queries;
public class GetAcceptedContactsQueryHandler : IRequestHandler<GetAcceptedContactsQuery, IEnumerable<AcceptedContact>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAcceptedContactsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AcceptedContact>> Handle(GetAcceptedContactsQuery request, CancellationToken cancellationToken) =>
        await _context.Contacts.Where((c) => c.Status == Status.ACCEPTED)
            .ProjectTo<AcceptedContact>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
}
