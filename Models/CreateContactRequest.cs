using MediatR;

namespace LeadsManagement.Application.Features.Commands.Create;
public record CreateContactRequest
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public string? Suburb { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
}