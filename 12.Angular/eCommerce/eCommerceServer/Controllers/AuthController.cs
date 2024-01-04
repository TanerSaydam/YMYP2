using AutoMapper;
using eCommerceServer.Context;
using eCommerceServer.DTOs;
using eCommerceServer.Models;
using eCommerceServer.Repositories;
using eCommerceServer.Services;
using eCommerceServer.Validators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class AuthController : ControllerBase
{
    private readonly IMapper _mapper;
    AppUserRepository appUserRepository;
    IConfiguration _configuration;
    public AuthController(IMapper mapper, IConfiguration configuration)
    {
        _mapper = mapper;
        appUserRepository = new();
        _configuration = configuration;
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
            return StatusCode(422,errorMessages);
        }

        //Kaydın Unique Kontrolü 
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
            return StatusCode(422, errorMessages);
        }

        //User Kontrolü        
        AppUser? user = appUserRepository.Login(request.Email, request.Password);

        if(user is null)
        {
            return BadRequest(new { Message = "Kullanıcı bulunamadı" });
        }

        //Token - JWT ile token Üreteceğiz
        JwtProvider jwtProvider = new(_configuration);
        string token = jwtProvider.CreateToken(user);

        return Ok(new {AccessToken = token});
    }
}
