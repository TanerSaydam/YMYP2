using Microsoft.AspNetCore.Mvc;
using TodoServer.Context;
using TodoServer.DTOs;
using TodoServer.Models;

namespace TodoServer.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private ApplicationDbContext context = new();

    [HttpGet]
    public IActionResult GetAll()
    {
        var todos = context.Todos.ToList();
        return Ok(todos);
    }

    [HttpPost]
    public IActionResult Add(AddTodoDto request)
    {
        Todo todo = new()
        {
            Title = request.Title,
            Completed = request.Completed
        };

        context.Add(todo);
        context.SaveChanges(); //transaction

        return NoContent();
    }

    [HttpGet("{id}")]
    public IActionResult RemoveById(Guid id)
    {
        var todo = context.Todos.Where(p => p.Id == id).FirstOrDefault();
        context.Remove(todo);
        context.SaveChanges();
        return NoContent();
    }

    [HttpPost]
    public IActionResult Update(UpdateTodoDto request)
    {
        var todo = context.Todos.Where(p => p.Id == request.Id).FirstOrDefault();
        todo.Title = request.Title;
        todo.Completed = request.Completed;

        context.SaveChanges();

        return NoContent();
    }
}