namespace ChatUIConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, I am Chat UI.");
        Console.WriteLine("I want to know you better.");
        Console.WriteLine("Please tell me your name?");
        string name = Console.ReadLine(); //sarı ya da mavi alt çizgi warning
        Console.WriteLine("Nice to meet you " + name);
        Console.WriteLine("Where are you from?");
        string from = Console.ReadLine();
        Console.WriteLine("Oww, that's great! I am from ABD");
        Console.WriteLine("How old are you?");
        string age = Console.ReadLine(); //kırmızı alt çizgi hata
        Console.WriteLine("Great! Ok, your name is " + name + " you write me from " + from + " and you are " + age + " years old.");
        Console.WriteLine("I am correct?");
        string result = Console.ReadLine();
        //şart blogları
        if(result == "Yes")
        {
            Console.WriteLine("That's great. I am really happy!");
        }
        else if(result == "No")
        {
            Console.WriteLine("Oww, I am sorry for misunderstanding");
        }
        else
        {
            Console.WriteLine("I don't understand your response!");
        }
    }
}
