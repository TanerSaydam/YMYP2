namespace PropertyVeClassYapilari;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new() { Name2 = "Taner" };

        user.Name1 = "Taner";
        //user.Name2 = "Taner"; //burada atayamam
        //user.Name3 = "Taner"; //bunu yapamayız!
        user.ChangeName3("Taner");

        Console.ReadLine();
    }
}

public class User
{
    //public User()
    //{
    //    Name3 = "";
    //}

    //public string Name = "Taner"; //değişken
    public string Name1 { get; set; } //property => 101 de kullanılır

    public string Name2 { get; init; } //property => daha çok DTO lar için
    public string Name3 { get; private set; } //= "Taner"; //property

    //domain driven design entitynin full kontrolü ele alma
    public void ChangeName3(string value)
    {
        Name3 = value;
    }
}