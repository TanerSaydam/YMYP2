using eCommerceServer.DTOs;
using FluentValidation;

namespace eCommerceServer.Validators;

public class RegisterDtoValidator : AbstractValidator<RegisterDto>
{
    public RegisterDtoValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty().MinimumLength(3);
        RuleFor(p => p.LastName).NotEmpty();
        RuleFor(p => p.LastName).MinimumLength(3);
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.Email).MinimumLength(3);
        RuleFor(p => p.Email).EmailAddress();
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.Password).MinimumLength(6);
        RuleFor(p => p.Password).Matches("[a-z]");
        RuleFor(p => p.Password).Matches("[A-Z]");
        RuleFor(p => p.Password).Matches("[0-9]");
    }
}
