namespace MyFirstConsoleApp;

internal class Program
{
    static void Main(string[] args)
    { //blok code bloğu
        Console.WriteLine("Hello, World!");

        //string int decimal double float boolean datetime object
        //type degisken_adi = degeri; //degisken syntax yapısı // sytanx hatası => kodlama yapaken kodda yapılan harf ya da tanımlama hatası
        string nameLastname = "Taner Saydam";
        int age = 33;
        decimal salary = 47500.20m;
        bool isActive = true; //false olumsuz -- 0 => false / 1=> true
        DateTime startDate = DateTime.Now; //September 26, 2023 21:23.10,000
        string name = "Taner";
        Console.WriteLine("Merhaba " + name);
        string readLine = Console.ReadLine();
        Console.WriteLine("Yazdığın şey: " + readLine);
    }
}
//scope


