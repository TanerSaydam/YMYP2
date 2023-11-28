using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.WebApi.Context;
using Server.WebApi.DTOs;
using Server.WebApi.Models;

namespace Server.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class TicketsController(
    ApplicationDbContext _context) : ControllerBase
{
    [HttpGet("{userId}")]
    public IActionResult GetAll(Guid userId)
    {
        var tickets = _context.Tickets.Where(p=> p.UserId == userId).OrderByDescending(p=> p.CreatedDate).ToList();

        return Ok(tickets);
    }

    [HttpPost]
    public IActionResult Create(TicketCreateDto request)
    {
        Ticket ticket = new()
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            UserId = request.UserId,
            Subject = request.Subject,
            IsUrgent = request.IsUrgent,
            Status = "Open"
        };

        _context.Add(ticket);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPost]
    public IActionResult ChangeStatus(TicketChangeStatusDto request)
    {
        Ticket? ticket = _context.Tickets.Find(request.Id);
        if(ticket is null)
        {
            throw new ArgumentException("Ticket is not found");
        }

        ticket.Status = request.Status;
        _context.SaveChanges();

        return NoContent();
    }
}
