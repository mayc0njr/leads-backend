using AutoMapper;
using LeadsManagement.Application.Features.Commands.Create;
using LeadsManagement.Application.Features.Commands.Delete;
using LeadsManagement.Application.Features.Queries;
using LeadsManagement.Applications.Features.Commands.Update;
using LeadsManagement.Entities;
using LeadsManagement.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeadsManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public ContactController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet("waiting")]
    public async Task<IEnumerable<WaitingContact>> GetWaitingContacts()
    {
        return await _mediator.Send(new GetWaitingContactsQuery());
    }

    [HttpGet("accepted")]
    public async Task<IEnumerable<AcceptedContact>> GetAcceptedContacts()
    {
        return await _mediator.Send(new GetAcceptedContactsQuery());
    }

    [HttpPost]
    public async Task<int> CreateContact([FromRoute] int id, [FromBody] CreateContactRequest request)
    {
        var command = _mapper.Map<CreateContactCommand>(request);
        return await _mediator.Send(command);
    }

    [HttpPatch]
    [Route("{id}")]
    public async Task<Contact> UpdateContact([FromRoute] int id, [FromBody] UpdateContactStatusRequest request)
    {
        return await _mediator.Send(new UpdateContactStatusCommand(){
            Id = id,
            Status = request.Status
        });
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteContact([FromRoute] int id)
    {
        await _mediator.Send(new DeleteContactCommand(id));
        return Ok();
        
    }
}