namespace TimerConsoleApp;

internal class Program
{
    //
    static void Main(string[] args)
    {
        Timer timer = new(TimerCallback, null, 0, 1000);
        Console.WriteLine("Çıkmak için [Enter] tuşuna basın!");
        Console.ReadLine();
    }

    static void TimerCallback(object state)
    {
        Console.WriteLine($"Saat: {DateTime.Now}");
    }
}
