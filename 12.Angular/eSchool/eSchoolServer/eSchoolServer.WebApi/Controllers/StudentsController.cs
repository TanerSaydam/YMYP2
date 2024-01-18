using eSchoolServer.WebApi.Authentication;
using eSchoolServer.WebApi.DTOs;
using eSchoolServer.WebApi.Models;
using GenericFileService.Files;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSchoolServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
[Authenticated]
public sealed class StudentsController : ControllerBase
{
    private static List<Student> Students = new();

    [HttpPost]
    public IActionResult Add([FromForm] AddStudentDto request)
    {
        //byte üzerinden tip kontrolü yapıp
        string fileName = FileService.FileSaveToServer(request.File, "wwwroot/files/");

        Student student = new Student()
        {
            Id = Students.Count() == 0 ? 1 : Students.LastOrDefault()!.Id + 1,
            Firstname = request.FirstName,
            Lastname = request.LastName,
            DateOfBirth = DateOnly.Parse(request.DateOfBirth),
            Image = "https://localhost:7135/files/" + fileName
        };

        Students.Add(student);

        return NoContent();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Students);
    }
}
