using System.ComponentModel.DataAnnotations;

namespace LeadsManagement.Entities;
public class Category
{

    public int Id { get; set; }
    [StringLength(20, MinimumLength = 4)]
    public string? Name { get; set; }
}