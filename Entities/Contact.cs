using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeadsManagement.Entities;
public class Contact
{
    public int Id { get; set; }
    [StringLength(80, MinimumLength = 4)]
    public string? Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    [StringLength(400, MinimumLength = 4)]
    public string? Description { get; set; }
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
    [StringLength(80, MinimumLength = 4)]
    public string? Suburb { get; set; }
    [StringLength(9, MinimumLength = 3)]
    public string? Phone { get; set; }
    [StringLength(80, MinimumLength = 4)]
    public string? Email { get; set; }
    public Status Status { get; set; } = Status.WAITING;



}