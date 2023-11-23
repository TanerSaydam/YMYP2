using Server.WebApi.Context;
using Server.WebApi.DTOs;
using Server.WebApi.Extensions;
using Server.WebApi.Models;
using Server.WebApi.Validators;

namespace Server.WebApi.Services;

public sealed class AuthService
{
    private readonly ApplicationDbContext _context;

    public AuthService(ApplicationDbContext context)
    {
        _context = context;
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

    private void CheckValidation(RegisterDto request)
    {
        var validator = new RegisterDtoValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            throw new ArgumentException(result.Errors[0].ErrorMessage);
        }
    }
}
