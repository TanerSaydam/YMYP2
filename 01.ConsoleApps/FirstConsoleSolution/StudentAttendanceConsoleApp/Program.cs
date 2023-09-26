namespace StudentAttendanceConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, this is my studens!");
        Console.WriteLine("01. Taner");
        Console.WriteLine("02. Ahmet");
        Console.WriteLine("03. Mehmet");
        Console.WriteLine("Tell me who is in class?");
        string result = Console.ReadLine();
        //int kontrolü ile sıfıtaki öğrencinin numarasını isteyin
        //int değer girilmezse hata fırlatın
        //değer int ise sınıftaki öğrenci numaralarında bu değeri arayın ve eğer böyle numaralı bir öğrenci yoksa hata fırlatın
        //eğer öğrenci varsa ekranda şu öğrenci sınıfta olarak işaretli yazsın ve sonra başka kim sınıfta diye sorsun
        //Aşağıdaki bonus ödevler için arrayler kullanmalısınız ya da listeler
        //Bonus ödev: Eğer öğrenci zaten sınıfta işaretlendiyse o zaman tekrar işretlemesin ve hata versin
        //Bonus ödev: tüm öğrenciler sınıfta olarak işaretlenirse uygulama tüm öğrenciler sınıfta desin ve kapansın
    }
}
