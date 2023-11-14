using AccessModifierProject.ConsoleApp.Models1;

namespace AccessModifierProject.ConsoleApp;

internal class Program
{
    //21:41 görüşelim
    static void Main(string[] args)
    {
        #region Public Erişim Belirleyicisi
        Test1 test1 = new() { PublicProperty = "Taner"}; //instance
        //test1.PublicProperty = "asdasd";
        //test1.InternalProperty = "";
        TestInhreit testInhreit = new();
        #endregion

        #region Internal Erişim Belirleyicisi
        //Test2 test2 = new();
        //databaseden veriyi çeker
        Test2 test2 = Test2.Create("Taner");

        //değiştir
        //test2.InternalProperty = "Taner";


        Test3 test3 = new();
        #endregion

        Console.WriteLine("Hello, World!");
    }
}

//public private internal protected