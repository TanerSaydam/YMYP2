namespace StudentAttendanceConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        //string[] students = new string[4]; //array
        List<Student> students = new()
        {
            new Student()
            {
                No = 1,
                Name = "Taner Saydam",
                Class = "2A",
                DateOfBirth = Convert.ToDateTime("03.09.1989")
            },
            new Student()
            {
                No = 2,
                Name = "Ahmet Yalın",
                Class = "2A",
                DateOfBirth = Convert.ToDateTime("01.01.1988")
            }
        };


        var student = new Student()
        {
            No = 3,
            Name = "Mehmet Can Ünaldı",
            Class = "2A",
            DateOfBirth = Convert.ToDateTime("01.02.1989")
        };

        students.Add(student);


        Console.WriteLine("Hi, this is my studens!");
        foreach(var s in students)
        {
            Console.WriteLine($@"
Number: {s.No}
Name: {s.Name}
Class: {s.Class},
Date Of Birth: {s.DateOfBirth}
------------------");
        }
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


//access modifier => erişim belirleyicisi
internal class Student
{
    public int No { get; set; }
    public string Name { get; set; } //property, TitleCase
    public string Class { get; set; }
    public DateTime DateOfBirth { get; set; }
}