using AutoMapper;
using eCommerceServer.Context;
using eCommerceServer.DTOs;
using eCommerceServer.Models;
using eCommerceServer.Repositories;
using eCommerceServer.Validators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class AuthController : ControllerBase
{
    private readonly IMapper _mapper;

    public AuthController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Register(RegisterDto request)
    {    
        //Validation Kontrolü
        RegisterDtoValidator validator = new();
        ValidationResult result = validator.Validate(request);
        if (!result.IsValid)
        {
            List<string> errorMessages = result.Errors.Select(s=> s.ErrorMessage).ToList();
            return BadRequest(errorMessages);
        }

        //Kaydın Unique Kontrolü
        AppUserRepository appUserRepository = new();

        bool isEmailExist = appUserRepository.IsEmailExists(request.Email);
        if (isEmailExist)
        {
            return BadRequest(new { Message = "Email adresi daha önce kaydedilmiş!" });
        }

        //Objenin Oluşturulması
        AppUser appUser = _mapper.Map<AppUser>(request);

        //Database Kaydının Yapılması
        appUserRepository.Add(appUser);

        return NoContent();
    }

    [HttpPost]
    public IActionResult Login(LoginDto request)
    {
        //Validation Kontrolü
        LoginDtoValidator validator = new();
        ValidationResult result = validator.Validate(request);
        if(!result.IsValid)
        {
            List<string> errorMessages = result.Errors.Select(s => s.ErrorMessage).ToList();
            return BadRequest(errorMessages);
        }

        //User Kontrolü
        AppUserRepository appUserRepository = new();
        AppUser? user = appUserRepository.Login(request.Email, request.Password);

        if(user is null)
        {
            return BadRequest(new { Message = "Kullanıcı bulunamadı" });
        }

        //Token - JWT ile token Üreteceğiz
        return Ok(user);
    }
}
