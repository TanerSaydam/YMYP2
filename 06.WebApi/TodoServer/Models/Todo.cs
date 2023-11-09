namespace TodoServer.Models;

public class Todo
{
    public Todo()
    {
        Id = Guid.NewGuid();
        Completed = false;
    }

    public Guid Id { get; set; } //ad465-54a6wd4-5a49w8d4aw
    public string Title { get; set; }
    public bool Completed { get; set; }
}