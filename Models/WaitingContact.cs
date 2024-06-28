using LeadsManagement.Entities;

namespace LeadsManagement.Models;

public record WaitingContact
{

    public int Id { get; set; }

    private string _name = "";
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = (value == null) ? "" : value.Split(' ')[0];
        }
    }
    public string? Description { get; set; }
    public Category? Category { get; set; }
    public string? Suburb { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
}