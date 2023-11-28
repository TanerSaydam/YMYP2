using Microsoft.EntityFrameworkCore.Infrastructure;
using Server.WebApi.Context;
using Server.WebApi.DTOs;
using Server.WebApi.Extensions;
using Server.WebApi.Models;
using Server.WebApi.Validators;

namespace Server.WebApi.Services;

public sealed class AuthService
{
    private readonly ApplicationDbContext _context;
    private readonly JwtProvider _jwtProvider;
    public AuthService(ApplicationDbContext context, JwtProvider jwtProvider)
    {
        _context = context;
        _jwtProvider = jwtProvider;
    }

    public void Register(RegisterDto request)
    {
        #region Validation Check
        CheckValidation(request);
        #endregion

        #region UserName ve Email Exists Kontrolü
        CheckUsernameAndEmailIsExists(request);
        #endregion

        #region Create Password
        byte[] passwordSalt, passwordHash;

        PasswordService.CreatePassword(request.Password, out passwordSalt, out passwordHash);
        #endregion

        #region Create User Object
        User user = CreateUser(request, passwordSalt, passwordHash);
        #endregion

        #region Kullanıcı Database Kayıt
        CreatingUserToDatabase(user);
        #endregion
    }

    public LoginResponseDto Login(LoginDto request)
    {
        #region Validation Check
        CheckValidation(request);
        #endregion

        //immutable => bir defa set edilip bir daha değiştirilemeyen nesnelere denir
        User? user = 
            _context.Users
            .FirstOrDefault(p => p.UserName == request.UsernameOrEmail || p.Email == request.UsernameOrEmail);

        if(user is null)  //iş kuralı | business logic
        {
            throw new ArgumentException("Kullanıcı bulunamadı");
        }

        var checkPasswordIsTrue = PasswordService.CheckPassword(user, request.Password);

        if(!checkPasswordIsTrue) //iş kuralı | business logic
        {
            throw new ArgumentException("Şifre yanlış");
        }

        return _jwtProvider.CreateToken(user, request.RememberMe);
    }

    private void CreatingUserToDatabase(User user)
    {
        _context.Add(user);
        _context.SaveChanges();
    }

    private User CreateUser(RegisterDto request, byte[] passwordSalt, byte[] passwordHash)
    {
        return new()
        {
            Name = request.Name,
            LastName = request.LastName,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            Email = request.Email,
            UserName = request.Username
        };
    }

    private void CheckUsernameAndEmailIsExists(RegisterDto request)
    {
        var checkUsernameIsExists = _context.Users.Any(p => p.UserName == request.Username);
        if (checkUsernameIsExists)
        {
            throw new ArgumentException("Bu kullanıcı adı daha önce kullanılmış");
        }

        var checkEmailIsExists = _context.Users.Any(p => p.Email == request.Email);
        if (checkEmailIsExists)
        {
            throw new ArgumentException("Bu mail adresi daha önce kullanılmış");
        }
    }

    private void CheckValidation<T>(T request)
        where T: class
    {
        string validatorName = typeof(T).FullName + "Validator";
        Type? validatorType = Type.GetType(validatorName);

        if (validatorType == null)
        {
            throw new InvalidOperationException("Validator class not found for " + typeof(T).FullName);
        }

        var validatorInstance = Activator.CreateInstance(validatorType);
        var validateMethod = validatorType.GetMethod("Validate");

        if (validateMethod == null)
        {
            throw new InvalidOperationException("Validate method not found in " + validatorName);
        }

        var result = validateMethod.Invoke(validatorInstance, new object[] { request });

        if (result is FluentValidation.Results.ValidationResult validationResult && !validationResult.IsValid)
        {
            throw new ArgumentException(validationResult.Errors[0].ErrorMessage);
        }
    }

    private void CheckValidation(RegisterDto request)
    {
        var validator = new RegisterDtoValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            throw new ArgumentException(result.Errors[0].ErrorMessage);
        }
    }

    private void CheckValidation(LoginDto request)
    {
        var validator = new LoginDtoValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            throw new ArgumentException(result.Errors[0].ErrorMessage);
        }
    }
}
