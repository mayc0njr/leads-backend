using MediatR;

namespace LeadsManagement.Application.Features.Commands.Delete;
public record DeleteContactCommand(int Id) : IRequest;