using LeadsManagement.Models;
using FluentValidation;
using LeadsManagement.Application.Constants.cs;

public class UpdateContactStatusRequestValidator : AbstractValidator<UpdateContactStatusRequest>
{
    public UpdateContactStatusRequestValidator()
    {
        RuleFor(u => u.Status)
            .IsInEnum()
            .WithMessage(Messages.INVALID_STATUS);
    }
}