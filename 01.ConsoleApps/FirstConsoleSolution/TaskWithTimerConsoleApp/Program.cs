namespace TaskWithTimerConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
    tasklariSetEtmeZiplamaNoktasi:;
        foreach (var task in TaskService.Tasks)
        {
            Timer timer = new Timer(DoTask, task.Description, 0, task.Duration);
        }

        Thread.Sleep(10000);
        goto tasklariSetEtmeZiplamaNoktasi;

    }

    static void DoTask(object state)
    {
        Console.WriteLine((string)state);
    }
}

