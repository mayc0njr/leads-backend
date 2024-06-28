using LeadsManagement.Entities;

namespace LeadsManagement.Models;
public record UpdateContactStatusRequest
{
    public Status Status { get; set; }
}