using AutoMapper;
using LeadsManagement.Application.Features.Commands.Create;
using LeadsManagement.Entities;
using LeadsManagement.Models;

namespace SeeSharp.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Contact, WaitingContact>();
        CreateMap<Contact, AcceptedContact>();
        CreateMap<CreateContactRequest, CreateContactCommand>();
    }
}