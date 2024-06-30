using LeadsManagement.Models;
using FluentValidation;

public class CreateContactRequestValidator : AbstractValidator<CreateContactRequest>
{
    public CreateContactRequestValidator()
    {
        RuleFor(u => u.Name)
            .Length(4, 80);
        
        RuleFor(u => u.Description)
            .Length(4, 400);
            
        RuleFor(u => u.Suburb)
            .Length(4, 80);
            
        RuleFor(u => u.Phone)
            .Length(3, 9);
            
        RuleFor(u => u.Email)
            .Length(4, 80)
            .EmailAddress();
    }
}
    
