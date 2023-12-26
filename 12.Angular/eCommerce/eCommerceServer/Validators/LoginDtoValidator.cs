using eCommerceServer.DTOs;
using FluentValidation;

namespace eCommerceServer.Validators;

public sealed class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {
        RuleFor(p => p.Email).NotEmpty().EmailAddress();
        RuleFor(p => p.Password).NotEmpty().MinimumLength(6).Matches("[a-z]").Matches("[A-Z]").Matches("[0-9]");
    }
}
