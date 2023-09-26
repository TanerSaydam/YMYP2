namespace NumberGuessingGameConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        //döngüler
        Console.WriteLine("Hi, My name is Number Guessing Game!");
        Console.WriteLine("and I want to play a game.");
        Console.WriteLine("I'll keep a number in mind and I will ask you to guess.");
        Console.WriteLine("If you are ready, let's start");
        Random random = new Random(); //classların istance türetmesi ya da newlenmesi ya da örneğinin türetilmesi
        int guessNumber = random.Next(1,100);
        Console.WriteLine("My guess number is: " + guessNumber);

        while (true) //sonsuz döngüler
        {
            Console.WriteLine("What is the number I keep in mind from 1 to 100?");
            string response = Console.ReadLine();
            int responseTypeNumber = 0;
            bool isConvertSuccess = int.TryParse(response, out responseTypeNumber);
            if (isConvertSuccess == false)
            {
                Console.WriteLine("Your answer is not a number!");
            }
            else
            {
                if (responseTypeNumber == guessNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number I keep");
                    break;
                }
                else
                {
                    Console.WriteLine("Your answer is wrong!");
                }
            }
        }        
        
    }
}
