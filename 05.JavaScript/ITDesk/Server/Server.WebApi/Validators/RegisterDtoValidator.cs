using FluentValidation;
using Server.WebApi.DTOs;

namespace Server.WebApi.Validators;

public sealed class RegisterDtoValidator : AbstractValidator<RegisterDto>
{
    public RegisterDtoValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Geçerli bir isim girin");
        RuleFor(p => p.Name).NotNull().WithMessage("Geçerli bir isim girin");
        RuleFor(p => p.Name).MinimumLength(3).WithMessage("İsim alanı en az 3 karakter olmalıdır");
        RuleFor(p => p.LastName).NotEmpty().WithMessage("Geçerli bir soyad girin");
        RuleFor(p => p.LastName).NotNull().WithMessage("Geçerli bir soyad girin");
        RuleFor(p => p.LastName).MinimumLength(3).WithMessage("Soyad alanı en az 3 karakter olmalıdır");
        RuleFor(p => p.Username).NotEmpty().WithMessage("Geçerli bir kullanıcı adı girin");
        RuleFor(p => p.Username).NotNull().WithMessage("Geçerli bir kullanıcı adı girin");
        RuleFor(p => p.Username).MinimumLength(3).WithMessage("Kullanıcı adı alanı en az 3 karakter olmalıdır");
        RuleFor(p => p.Email).NotEmpty().WithMessage("Geçerli bir mail adresi girin");
        RuleFor(p => p.Email).NotNull().WithMessage("Geçerli bir mail adresi girin");
        RuleFor(p => p.Email).EmailAddress().WithMessage("Geçerli bir mail adresi girin");
        RuleFor(p => p.Email).MinimumLength(3).WithMessage("Mail adresi alanı en az 3 karakter olmalıdır");
        RuleFor(p=> p.Password).NotEmpty().WithMessage("Geçerli bir şifre girin");
        RuleFor(p=> p.Password).NotNull().WithMessage("Geçerli bir şifre girin");
        RuleFor(p=> p.Password).Matches("[A-Z]").WithMessage("Şifreniz en az 1 adet büyük harf içermelidir");
        RuleFor(p=> p.Password).Matches("[a-z]").WithMessage("Şifreniz en az 1 adet küçük harf içermelidir");
        RuleFor(p=> p.Password).Matches("[0-9]").WithMessage("Şifreniz en az 1 adet rakam içermelidir");
        RuleFor(p=> p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifreniz en az 1 adet özel karakter içermelidir");
    }
}

public sealed class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {
        RuleFor(p => p.UsernameOrEmail).NotEmpty().WithMessage("Geçerli bir kullanıcı adı ya da mail adresi girin");
        RuleFor(p => p.UsernameOrEmail).NotNull().WithMessage("Geçerli bir kullanıcı adı ya da mail adresi girin");
        RuleFor(p => p.UsernameOrEmail).MinimumLength(3).WithMessage("Kullanıcı adı|mail adresi alanı en az 3 karakter olmalıdır");
        RuleFor(p => p.Password).NotEmpty().WithMessage("Geçerli bir şifre girin");
        RuleFor(p => p.Password).NotNull().WithMessage("Geçerli bir şifre girin");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Şifreniz en az 1 adet büyük harf içermelidir");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Şifreniz en az 1 adet küçük harf içermelidir");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Şifreniz en az 1 adet rakam içermelidir");
        RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifreniz en az 1 adet özel karakter içermelidir");
    }
}
