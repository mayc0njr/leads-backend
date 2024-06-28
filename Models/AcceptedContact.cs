using LeadsManagement.Entities;


namespace LeadsManagement.Models;
public record AcceptedContact
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? Description { get; set; }
    public Category? Category { get; set; }
    public decimal Price { get; set; }
    public string? Suburb { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
}