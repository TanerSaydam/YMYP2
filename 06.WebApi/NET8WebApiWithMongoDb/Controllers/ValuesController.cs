using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using NET8WebApiWithMongoDb.DTOs;
using NET8WebApiWithMongoDb.Models;
using System.Diagnostics;

namespace NET8WebApiWithMongoDb.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class ValuesController : ControllerBase
{
    private readonly IMongoCollection<Todo> _todo;
    public ValuesController()
    {
        var client = new MongoClient("mongodb://127.0.0.1:27017");
        var database = client.GetDatabase("tododb");

        _todo = database.GetCollection<Todo>("todos");
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {

        //List<Todo> todoList = new();
        //for (int i = 0; i < 300000; i++)
        //{
        //    Faker faker = new();
        //    Todo todo = new()
        //    {
        //        Work = faker.Name.FullName(),
        //        Date = DateTime.Now.AddHours(3),
        //    };
        //    todoList.Add(todo);
        //}

        //await _todo.InsertManyAsync(todoList);
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        var todos = await _todo.Find(todo => true).SortByDescending(s=> s.Date).Limit(100).ToListAsync();
        stopwatch.Stop();

        var result = stopwatch.Elapsed.TotalMilliseconds;
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Save(TodoSaveDto request)
    {
        Todo todo = new()
        {
            Work = request.Value,
            Date = DateTime.Now.AddHours(3)
        };

        await _todo.InsertOneAsync(todo);
        return Ok(new {Message = ""});
    }

    [HttpPost]
    public async Task<IActionResult> RemoveById(TodoRemoveDto request)
    {
        await _todo.FindOneAndDeleteAsync(f => f._id == request._Id);

        return Ok(new { Message = "" });
    }

    [HttpPost]
    public async Task<IActionResult> Update(TodoUpdateDto request)
    {
        var update = Builders<Todo>.Update.Set(t => t.Work, request.Value).Set(t => t.Date, DateTime.Now.AddHours(3));        
        await _todo.FindOneAndUpdateAsync(f=> f._id == request._Id, update);

        return Ok(new { Message = "" });
    }
}


